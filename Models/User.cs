using System.ComponentModel.DataAnnotations;

namespace Cookistry.Models;

public class User
{
    public int UserId { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string PasswordHash { get; set; }
    public DateTime AccountCreated { get; set; }
}