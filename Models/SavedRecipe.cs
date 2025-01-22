using System.ComponentModel.DataAnnotations;

namespace Cookistry.Models;

public class SavedRecipe
{
    public int UserId { get; set; }
    public int RecipeId { get; set; }

    public User? User { get; set; }
    public Recipe? Recipe { get; set; }
}
