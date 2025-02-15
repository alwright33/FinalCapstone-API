namespace Cookistry.Models.DTOs;

public class RecipeIngredientDTO
{
    public int RecipeId { get; set; }
    public int IngredientId { get; set; }
    public string? Name { get; set; }
    public decimal Quantity { get; set; }
    public string? Unit { get; set; }
    public string? PrepDetails { get; set; }
}
