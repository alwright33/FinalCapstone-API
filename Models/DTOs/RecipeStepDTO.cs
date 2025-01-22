namespace Cookistry.Models.DTOs;

public class RecipeStepDTO
{
    public int StepId { get; set; }
    public int RecipeId { get; set; }
    public int StepNumber { get; set; }
    public string? StepInstruction { get; set; }
}