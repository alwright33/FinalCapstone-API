namespace Cookistry.Models.DTOs;

public class CreateRecipeIngredientDTO
{
    public int IngredientId { get; set; }
    public decimal Quantity { get; set; }
    public string? Unit { get; set; }
    public string? PrepDetails { get; set; }
}