namespace Cookistry.Models.DTOs;
using System.ComponentModel.DataAnnotations;

public class CreateRecipeDTO
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public int CookTime { get; set; }

    [Required]
    public int PrepTime { get; set; }

    [Required]
    public string Difficulty { get; set; }

    public List<CreateRecipeIngredientDTO> Ingredients { get; set; }
    public List<CreateRecipeStepDTO> Steps { get; set; }

}


