namespace Cookistry.Models.DTOs;
using System.ComponentModel.DataAnnotations;

public class CreateRecipeDTO
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public int CookTime { get; set; }

    public int PrepTime { get; set; }

    public string? Difficulty { get; set; }

    public List<CreateRecipeIngredientDTO>? Ingredients { get; set; }
    public List<CreateRecipeStepDTO>? Steps { get; set; }

}


