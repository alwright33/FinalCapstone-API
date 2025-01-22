using System.ComponentModel.DataAnnotations;

namespace Cookistry.Models;

public class User
{
    public int UserId { get; set; }
    [Required]
    public required string Username { get; set; }
    [Required]
    public required string FirstName { get; set; }
    [Required]
    public required string LastName { get; set; }
    [Required]
    public required string Email { get; set; }
    [Required]
    public required string PasswordHash { get; set; }
    public DateTime AccountCreated { get; set; }
}