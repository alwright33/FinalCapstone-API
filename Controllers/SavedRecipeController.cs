using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cookistry.Models;
using Cookistry.Models.DTOs;

namespace Cookistry.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SavedRecipesController : ControllerBase
    {
        private readonly CookistryDbContext _context;

        public SavedRecipesController(CookistryDbContext context)
        {
            _context = context;
        }

        private static SavedRecipeDTO MapToSavedRecipeDTO(SavedRecipe savedRecipe)
        {
            return new SavedRecipeDTO
            {
                UserId = savedRecipe.UserId,
                RecipeId = savedRecipe.RecipeId
            };
        }

        // GET: api/SavedRecipes/user/{userId}
        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<SavedRecipeDTO>>> GetSavedRecipes(int userId)
        {
            var savedRecipes = await _context.SavedRecipes
                .Include(sr => sr.Recipe)
                .Where(sr => sr.UserId == userId)
                .Select(sr => new SavedRecipeDTO
                {
                    RecipeId = sr.RecipeId,
                    Name = sr.Recipe.Name,
                    Difficulty = sr.Recipe.Difficulty,
                    UserId = sr.UserId
                })
                .ToListAsync();

            return Ok(savedRecipes);
        }


        // POST: api/SavedRecipes/user/{userId}
        [HttpPost("user/{userId}")]
        public async Task<ActionResult<SavedRecipeDTO>> SaveRecipe(int userId, [FromBody] CreateSavedRecipeDTO createSavedRecipeDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userExists = await _context.Users.AnyAsync(u => u.UserId == userId);
            if (!userExists)
            {
                return NotFound(new { message = "User not found." });
            }

            var recipeExists = await _context.Recipes.AnyAsync(r => r.RecipeId == createSavedRecipeDTO.RecipeId);
            if (!recipeExists)
            {
                return NotFound(new { message = "Recipe not found." });
            }

            var savedRecipe = new SavedRecipe
            {
                UserId = userId,
                RecipeId = createSavedRecipeDTO.RecipeId
            };

            _context.SavedRecipes.Add(savedRecipe);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, new { message = "An error occurred while saving the recipe.", details = ex.Message });
            }

            return CreatedAtAction(nameof(GetSavedRecipes), new { userId }, MapToSavedRecipeDTO(savedRecipe));
        }

        // DELETE: api/SavedRecipes/user/{userId}/recipe/{recipeId}
        [HttpDelete("user/{userId}/recipe/{recipeId}")]
        public async Task<IActionResult> RemoveSavedRecipe(int userId, int recipeId)
        {
            var savedRecipe = await _context.SavedRecipes
                .FirstOrDefaultAsync(sr => sr.UserId == userId && sr.RecipeId == recipeId);

            if (savedRecipe == null)
            {
                return NotFound(new { message = "Saved recipe not found." });
            }

            _context.SavedRecipes.Remove(savedRecipe);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while removing the saved recipe.", details = ex.Message });
            }

            return NoContent();
        }
    }
}
