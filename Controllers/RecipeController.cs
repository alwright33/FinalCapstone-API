using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cookistry.Models;
using Cookistry.Models.DTOs;

namespace Cookistry.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly CookistryDbContext _context;

        public RecipesController(CookistryDbContext context)
        {
            _context = context;
        }

        private static RecipeDTO MapToRecipeDTO(Recipe recipe)
        {
            return new RecipeDTO
            {
                RecipeId = recipe.RecipeId,
                Name = recipe.Name,
                Description = recipe.Description,
                CookTime = recipe.CookTime,
                PrepTime = recipe.PrepTime,
                Difficulty = recipe.Difficulty,
                AuthorId = recipe.AuthorId,
                CreatedDate = recipe.CreatedDate
            };
        }

        // GET: api/Recipes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecipeDTO>>> GetRecipes()
        {
            var recipes = await _context.Recipes
                .Select(recipe => MapToRecipeDTO(recipe))
                .ToListAsync();

            return Ok(recipes);
        }

        // GET: api/Recipes/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<RecipeDTO>> GetRecipe(int id)
        {
            var recipe = await _context.Recipes
                .Include(r => r.RecipeIngredients)
                    .ThenInclude(ri => ri.Ingredient)
                .Include(r => r.RecipeSteps)
                .FirstOrDefaultAsync(r => r.RecipeId == id);

            if (recipe == null)
            {
                return NotFound(new { message = "Recipe not found." });
            }

            var recipeDTO = new RecipeDTO
            {
                RecipeId = recipe.RecipeId,
                Name = recipe.Name,
                Description = recipe.Description,
                CookTime = recipe.CookTime,
                PrepTime = recipe.PrepTime,
                Difficulty = recipe.Difficulty,
                RecipeIngredients = recipe.RecipeIngredients.Select(ri => new RecipeIngredientDTO
                {
                    IngredientId = ri.IngredientId,
                    Name = ri.Ingredient.Name,
                    Quantity = ri.Quantity,
                    Unit = ri.Unit,
                    PrepDetails = ri.PrepDetails
                }).ToList(),
                RecipeSteps = recipe.RecipeSteps.Select(rs => new RecipeStepDTO
                {
                    StepNumber = rs.StepNumber,
                    StepInstruction = rs.StepInstruction
                }).ToList()
            };

            return Ok(recipeDTO);
        }

        // POST: api/Recipes/
        [HttpPost]
        public async Task<IActionResult> CreateRecipe([FromBody] CreateRecipeDTO recipeDto, [FromQuery] int userId)
        {
            try
            {
                // Validate user
                var user = await _context.Users.FindAsync(userId);
                if (user == null)
                {
                    return Unauthorized(new { message = "Invalid user." });
                }

                // Validate model state
                if (!ModelState.IsValid)
                {
                    return BadRequest(new
                    {
                        message = "Validation failed.",
                        errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage))
                    });
                }

                // Map recipe data
                var recipe = new Recipe
                {
                    Name = recipeDto.Name,
                    Description = recipeDto.Description,
                    CookTime = recipeDto.CookTime,
                    PrepTime = recipeDto.PrepTime,
                    Difficulty = recipeDto.Difficulty,
                    AuthorId = userId,
                    CreatedDate = DateTime.UtcNow,
                    RecipeIngredients = recipeDto.Ingredients.Select(i => new RecipeIngredient
                    {
                        IngredientId = i.IngredientId,
                        Quantity = i.Quantity,
                        Unit = i.Unit,
                        PrepDetails = i.PrepDetails
                    }).ToList(),
                    RecipeSteps = recipeDto.Steps.Select(s => new RecipeStep
                    {
                        StepNumber = s.StepNumber,
                        StepInstruction = s.StepInstruction
                    }).ToList()
                };

                // Save to the database
                _context.Recipes.Add(recipe);
                await _context.SaveChangesAsync();

                // Return the created recipe
                return CreatedAtAction(nameof(GetRecipe), new { id = recipe.RecipeId }, recipe);
            }
            catch (Exception ex)
            {
                // Log the error and return JSON response
                Console.WriteLine($"Error Creating Recipe: {ex.Message}");
                return StatusCode(500, new { message = "An error occurred while creating the recipe.", details = ex.Message });
            }
        }





        // PUT: api/Recipes/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRecipe(int id, [FromBody] RecipeDTO recipeDTO)
        {
            if (id != recipeDTO.RecipeId)
            {
                return BadRequest(new { message = "Recipe ID mismatch." });
            }

            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe == null)
            {
                return NotFound(new { message = "Recipe not found." });
            }

            recipe.Name = recipeDTO.Name;
            recipe.Description = recipeDTO.Description;
            recipe.CookTime = recipeDTO.CookTime;
            recipe.PrepTime = recipeDTO.PrepTime;
            recipe.Difficulty = recipeDTO.Difficulty;

            _context.Entry(recipe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Recipes.Any(r => r.RecipeId == id))
                {
                    return NotFound(new { message = "Recipe not found." });
                }

                throw;
            }

            return NoContent();
        }

        // DELETE: api/Recipes/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipe(int id)
        {
            var recipe = await _context.Recipes.FindAsync(id);

            if (recipe == null)
            {
                return NotFound(new { message = "Recipe not found." });
            }

            _context.Recipes.Remove(recipe);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while deleting the recipe.", details = ex.Message });
            }

            return NoContent();
        }
    }
}
