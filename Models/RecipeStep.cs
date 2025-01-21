using System.ComponentModel.DataAnnotations;

namespace Cookistry.Models;

public class RecipeStep
{
    [Key]
    public int StepId { get; set; }

    [Required]
    public int RecipeId { get; set; }

    [Required]
    public int StepNumber { get; set; }

    [Required]
    public string StepInstruction { get; set; }

}
