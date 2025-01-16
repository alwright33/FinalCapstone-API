namespace Cookistry.Models.DTOs;

public class SavedRecipeDTO
{
    public int RecipeId { get; set; }
    public string Name { get; set; }
    public string Difficulty { get; set; }
    public int UserId { get; set; }
}