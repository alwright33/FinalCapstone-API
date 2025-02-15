using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cookistry.Models;
using Cookistry.Models.DTOs;

namespace Cookistry.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeIngredientsController : ControllerBase
    {
        private readonly CookistryDbContext _context;

        public RecipeIngredientsController(CookistryDbContext context)
        {
            _context = context;
        }

        private static RecipeIngredientDTO MapToRecipeIngredientDTO(RecipeIngredient recipeIngredient)
        {
            return new RecipeIngredientDTO
            {
                RecipeId = recipeIngredient.RecipeId,
                IngredientId = recipeIngredient.IngredientId,
                Quantity = recipeIngredient.Quantity,
                Unit = recipeIngredient.Unit,
                PrepDetails = recipeIngredient.PrepDetails
            };
        }

        // GET: api/RecipeIngredients/recipe/{recipeId}
        [HttpGet("recipe/{recipeId}")]
        public async Task<ActionResult<IEnumerable<RecipeIngredientDTO>>> GetIngredientsForRecipe(int recipeId)
        {

            var recipeIngredients = await _context.RecipeIngredients
                .Where(ri => ri.RecipeId == recipeId)
                .Include(ri => ri.Ingredient)
                .ToListAsync();


            foreach (var ri in recipeIngredients)
            {
                Console.WriteLine($"RecipeId: {ri.RecipeId}, IngredientId: {ri.IngredientId}, Quantity: {ri.Quantity}, Unit: {ri.Unit}");
            }

            var recipeIngredientDTOs = recipeIngredients
                .Select(ri => new RecipeIngredientDTO
                {
                    RecipeId = ri.RecipeId,
                    IngredientId = ri.IngredientId,
                    Name = ri.Ingredient.Name,
                    Quantity = ri.Quantity,
                    Unit = ri.Unit,
                    PrepDetails = ri.PrepDetails
                })
                .ToList();
            foreach (var dto in recipeIngredientDTOs)
            {
                Console.WriteLine($"DTO - RecipeId: {dto.RecipeId}, IngredientId: {dto.IngredientId}, Name: {dto.Name}");
            }

            if (!recipeIngredientDTOs.Any())
            {
                Console.WriteLine($"No ingredients found for RecipeId: {recipeId}");
                return NotFound(new { message = "No ingredients found for the specified recipe." });
            }

            return Ok(recipeIngredientDTOs);
        }

        // POST: api/RecipeIngredients/recipe/{recipeId}
        [HttpPost("recipe/{recipeId}")]
        public async Task<ActionResult<RecipeIngredientDTO>> AddIngredientToRecipe(int recipeId, [FromBody] CreateRecipeIngredientDTO createRecipeIngredientDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var recipeExists = await _context.Recipes.AnyAsync(r => r.RecipeId == recipeId);
            if (!recipeExists)
            {
                return NotFound(new { message = "Recipe not found." });
            }

            var ingredientExists = await _context.Ingredients.AnyAsync(i => i.IngredientId == createRecipeIngredientDTO.IngredientId);
            if (!ingredientExists)
            {
                return NotFound(new { message = "Ingredient not found." });
            }

            var recipeIngredient = new RecipeIngredient
            {
                RecipeId = recipeId,
                IngredientId = createRecipeIngredientDTO.IngredientId,
                Quantity = createRecipeIngredientDTO.Quantity,
                Unit = createRecipeIngredientDTO.Unit,
                PrepDetails = createRecipeIngredientDTO.PrepDetails
            };

            _context.RecipeIngredients.Add(recipeIngredient);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, new { message = "An error occurred while adding the ingredient to the recipe.", details = ex.Message });
            }

            return CreatedAtAction(nameof(GetIngredientsForRecipe), new { recipeId }, MapToRecipeIngredientDTO(recipeIngredient));
        }

        // PUT: api/RecipeIngredients/recipe/{recipeId}/ingredient/{ingredientId}
        [HttpPut("recipe/{recipeId}/ingredient/{ingredientId}")]
        public async Task<IActionResult> UpdateRecipeIngredient(int recipeId, int ingredientId, [FromBody] RecipeIngredientDTO recipeIngredientDTO)
        {
            if (recipeId != recipeIngredientDTO.RecipeId || ingredientId != recipeIngredientDTO.IngredientId)
            {
                return BadRequest(new { message = "Recipe or ingredient ID mismatch." });
            }

            var recipeIngredient = await _context.RecipeIngredients
                .FirstOrDefaultAsync(ri => ri.RecipeId == recipeId && ri.IngredientId == ingredientId);

            if (recipeIngredient == null)
            {
                return NotFound(new { message = "Recipe ingredient not found." });
            }

            recipeIngredient.Quantity = recipeIngredientDTO.Quantity;
            recipeIngredient.Unit = recipeIngredientDTO.Unit;
            recipeIngredient.PrepDetails = recipeIngredientDTO.PrepDetails;

            _context.Entry(recipeIngredient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        // DELETE: api/RecipeIngredients/recipe/{recipeId}/ingredient/{ingredientId}
        [HttpDelete("recipe/{recipeId}/ingredient/{ingredientId}")]
        public async Task<IActionResult> RemoveIngredientFromRecipe(int recipeId, int ingredientId)
        {
            var recipeIngredient = await _context.RecipeIngredients
                .FirstOrDefaultAsync(ri => ri.RecipeId == recipeId && ri.IngredientId == ingredientId);

            if (recipeIngredient == null)
            {
                return NotFound(new { message = "Recipe ingredient not found." });
            }

            _context.RecipeIngredients.Remove(recipeIngredient);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while removing the ingredient from the recipe.", details = ex.Message });
            }

            return NoContent();
        }
    }
}
