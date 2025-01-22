namespace Cookistry.Models.DTOs;

public class RecipeDTO
{
    public int RecipeId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int CookTime { get; set; }
    public int PrepTime { get; set; }
    public string? Difficulty { get; set; }
    public int AuthorId { get; set; }
    public DateTime CreatedDate { get; set; }
    public List<RecipeStepDTO>? Steps { get; set; }
    public List<RecipeIngredientDTO>? Ingredients { get; set; }
}
