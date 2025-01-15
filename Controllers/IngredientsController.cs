using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cookistry.Models;
using Cookistry.Models.DTOs;

namespace Cookistry.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IngredientsController : ControllerBase
    {
        private readonly CookistryDbContext _context;

        public IngredientsController(CookistryDbContext context)
        {
            _context = context;
        }

        private static IngredientDTO MapToIngredientDTO(Ingredient ingredient)
        {
            return new IngredientDTO
            {
                IngredientId = ingredient.IngredientId,
                Name = ingredient.Name
            };
        }

        // GET: api/Ingredients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IngredientDTO>>> GetIngredients()
        {
            var ingredients = await _context.Ingredients
                .Select(ingredient => MapToIngredientDTO(ingredient))
                .ToListAsync();

            return Ok(ingredients);
        }

        // GET: api/Ingredients/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<IngredientDTO>> GetIngredient(int id)
        {
            var ingredient = await _context.Ingredients.FindAsync(id);

            if (ingredient == null)
            {
                return NotFound(new { message = "Ingredient not found." });
            }

            return Ok(MapToIngredientDTO(ingredient));
        }

        // POST: api/Ingredients
        [HttpPost]
        public async Task<ActionResult<IngredientDTO>> CreateIngredient([FromBody] CreateIngredientDTO createIngredientDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ingredient = new Ingredient
            {
                Name = createIngredientDTO.Name
            };

            _context.Ingredients.Add(ingredient);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, new { message = "An error occurred while creating the ingredient.", details = ex.Message });
            }

            return CreatedAtAction(nameof(GetIngredient), new { id = ingredient.IngredientId }, MapToIngredientDTO(ingredient));
        }

        // PUT: api/Ingredients/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateIngredient(int id, [FromBody] IngredientDTO ingredientDTO)
        {
            if (id != ingredientDTO.IngredientId)
            {
                return BadRequest(new { message = "Ingredient ID mismatch." });
            }

            var ingredient = await _context.Ingredients.FindAsync(id);
            if (ingredient == null)
            {
                return NotFound(new { message = "Ingredient not found." });
            }

            ingredient.Name = ingredientDTO.Name;

            _context.Entry(ingredient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Ingredients.Any(i => i.IngredientId == id))
                {
                    return NotFound(new { message = "Ingredient not found." });
                }

                throw;
            }

            return NoContent();
        }

        // DELETE: api/Ingredients/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngredient(int id)
        {
            var ingredient = await _context.Ingredients.FindAsync(id);

            if (ingredient == null)
            {
                return NotFound(new { message = "Ingredient not found." });
            }

            _context.Ingredients.Remove(ingredient);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while deleting the ingredient.", details = ex.Message });
            }

            return NoContent();
        }
    }
}
