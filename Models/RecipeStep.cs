using System.ComponentModel.DataAnnotations;

namespace Cookistry.Models;

public class RecipeStep
{
    [Key]
    public int StepId { get; set; }

    public int RecipeId { get; set; }

    public required int StepNumber { get; set; }

    public required string StepInstruction { get; set; }

}
