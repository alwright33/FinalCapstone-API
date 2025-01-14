namespace Cookistry.DTOs;

public class RecipeIngredientDTO
{
    public int RecipeId { get; set; }
    public int IngredientId { get; set; }
    public int Quantity { get; set; }
    public string Unit { get; set; }
    public string PrepDetails { get; set; }
}
