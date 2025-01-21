using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cookistry.Models;
using Cookistry.Models.DTOs;

namespace Cookistry.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeStepsController : ControllerBase
    {
        private readonly CookistryDbContext _context;

        public RecipeStepsController(CookistryDbContext context)
        {
            _context = context;
        }

        private static RecipeStepDTO MapToRecipeStepDTO(RecipeStep step)
        {
            return new RecipeStepDTO
            {
                StepId = step.StepId,
                RecipeId = step.RecipeId,
                StepNumber = step.StepNumber,
                StepInstruction = step.StepInstruction
            };
        }

        // GET: api/RecipeSteps/recipe/{recipeId}
        [HttpGet("recipe/{recipeId}")]
        public async Task<ActionResult<IEnumerable<RecipeStepDTO>>> GetStepsForRecipe(int recipeId)
        {
            var steps = await _context.RecipeSteps
                .Where(step => step.RecipeId == recipeId)
                .OrderBy(step => step.StepNumber)
                .Select(step => MapToRecipeStepDTO(step))
                .ToListAsync();

            if (!steps.Any())
            {
                return NotFound(new { message = "No steps found for the specified recipe." });
            }

            return Ok(steps);
        }

        // GET: api/RecipeSteps/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<RecipeStepDTO>> GetRecipeStep(int id)
        {
            var step = await _context.RecipeSteps.FindAsync(id);

            if (step == null)
            {
                return NotFound(new { message = "Recipe step not found." });
            }

            return Ok(MapToRecipeStepDTO(step));
        }

        // POST: api/RecipeSteps
        [HttpPost]
        public async Task<ActionResult<RecipeStepDTO>> CreateRecipeStep([FromBody] CreateRecipeStepDTO createStepDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var step = new RecipeStep
            {
                StepNumber = createStepDTO.StepNumber,
                StepInstruction = createStepDTO.StepInstruction
            };

            _context.RecipeSteps.Add(step);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, new { message = "An error occurred while creating the recipe step.", details = ex.Message });
            }

            return CreatedAtAction(nameof(GetRecipeStep), new { id = step.StepId }, MapToRecipeStepDTO(step));
        }

        // PUT: api/RecipeSteps/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRecipeStep(int id, [FromBody] RecipeStepDTO stepDTO)
        {
            if (id != stepDTO.StepId)
            {
                return BadRequest(new { message = "Step ID mismatch." });
            }

            var step = await _context.RecipeSteps.FindAsync(id);
            if (step == null)
            {
                return NotFound(new { message = "Recipe step not found." });
            }

            step.StepNumber = stepDTO.StepNumber;
            step.StepInstruction = stepDTO.StepInstruction;

            _context.Entry(step).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.RecipeSteps.Any(s => s.StepId == id))
                {
                    return NotFound(new { message = "Recipe step not found." });
                }

                throw;
            }

            return NoContent();
        }

        // DELETE: api/RecipeSteps/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipeStep(int id)
        {
            var step = await _context.RecipeSteps.FindAsync(id);

            if (step == null)
            {
                return NotFound(new { message = "Recipe step not found." });
            }

            _context.RecipeSteps.Remove(step);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while deleting the recipe step.", details = ex.Message });
            }

            return NoContent();
        }
    }
}
