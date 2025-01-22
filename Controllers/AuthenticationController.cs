// Adjusted AuthenticationController.cs to improve existing token system

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using Cookistry.Models;
using Cookistry.Models.DTOs;

namespace Cookistry.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly CookistryDbContext _context;

        public AuthenticationController(CookistryDbContext context)
        {
            _context = context;
        }

        // Helper Method: Hash Password
        private static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password)));
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO loginDTO)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == loginDTO.Email && u.PasswordHash == HashPassword(loginDTO.Password));
            if (user == null)
            {
                return Unauthorized(new { message = "Invalid email or password." });
            }

            return Ok(new { userId = user.UserId });
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] RegisterDTO registerDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var emailExists = await _context.Users.AnyAsync(u => u.Email.ToLower() == registerDTO.Email.ToLower());
            if (emailExists)
            {
                return Conflict(new { message = "Email already in use." });
            }

            var user = new User
            {
                Username = registerDTO.Username,
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
                Email = registerDTO.Email,
                PasswordHash = HashPassword(registerDTO.Password),
                AccountCreated = DateTime.UtcNow
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Register), new { id = user.UserId }, new { message = "Registration successful.", userId = user.UserId });
        }
    }
}
