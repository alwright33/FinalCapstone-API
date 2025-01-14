using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cookistry.Models;

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

        // GET: api/Ingredients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ingredient>>> GetIngredients()
        {
            try
            {
                var ingredients = await _context.Ingredients.ToListAsync();
                return Ok(ingredients);
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                return StatusCode(500, new { message = "An error occurred while fetching the ingredients.", details = ex.Message });
            }
        }
    }
}
