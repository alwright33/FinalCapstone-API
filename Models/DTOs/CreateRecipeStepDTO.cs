namespace Cookistry.Models.DTOs;

public class CreateRecipeStepDTO
{
    public int RecipeId { get; set; }
    public int StepNumber { get; set; }
    public string StepInstruction { get; set; }
}