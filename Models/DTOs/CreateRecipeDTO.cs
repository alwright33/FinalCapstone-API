namespace Cookistry.Models.DTOs;

public class CreateRecipeDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int CookTime { get; set; }
    public int PrepTime { get; set; }
    public string Difficulty { get; set; }
    public int AuthorId { get; set; }
}