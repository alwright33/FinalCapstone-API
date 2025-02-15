using System.ComponentModel.DataAnnotations;

namespace Cookistry.Models;

public class RecipeIngredient
{
    [Key]
    public int RecipeId { get; set; }
    public int IngredientId { get; set; }
    public decimal Quantity { get; set; }
    public string? Unit { get; set; }
    public string? PrepDetails { get; set; }

    public Ingredient Ingredient { get; set; }
}
