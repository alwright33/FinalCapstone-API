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
            var recipe = await _context.Recipes.FindAsync(id);

            if (recipe == null)
            {
                return NotFound(new { message = "Recipe not found." });
            }

            return Ok(MapToRecipeDTO(recipe));
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecipe([FromBody] CreateRecipeDTO recipeDto, [FromQuery] int userId)
        {
            try
            {
                // Check if user exists
                var user = await _context.Users.FindAsync(userId);
                if (user == null)
                {
                    return Unauthorized(new { message = "Invalid user." });
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(new
                    {
                        message = "Validation failed.",
                        errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage))
                    });
                }

                var recipe = new Recipe
                {
                    Name = recipeDto.Name,
                    Description = recipeDto.Description,
                    CookTime = recipeDto.CookTime,
                    PrepTime = recipeDto.PrepTime,
                    Difficulty = recipeDto.Difficulty,
                    AuthorId = userId, // Use UserId from query
                    CreatedDate = DateTime.UtcNow
                };

                _context.Recipes.Add(recipe);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetRecipe), new { id = recipe.RecipeId }, recipe);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, new { message = "Internal server error", details = ex.Message });
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
