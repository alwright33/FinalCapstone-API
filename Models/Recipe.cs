using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Cookistry.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }

        public required string Name { get; set; }

        [Required]
        public required string Description { get; set; }

        public int CookTime { get; set; }
        public int PrepTime { get; set; }

        [Required]
        public required string Difficulty { get; set; }

        public int AuthorId { get; set; }
        public DateTime CreatedDate { get; set; }


        public ICollection<RecipeStep>? RecipeSteps { get; set; }
        public ICollection<RecipeIngredient>? RecipeIngredients { get; set; }
    }
}
