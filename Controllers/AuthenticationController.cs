using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cookistry.Models;
using Cookistry.Models.DTOs;
using System.Security.Cryptography;
using System.Text;

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

        // POST: api/Authentication/login
        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Step 1: Find the user by email (case-insensitive)
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email.ToLower() == loginDTO.Email.ToLower());

            if (user == null)
            {
                return Unauthorized(new { message = "Invalid email or password." });
            }

            // Step 2: Hash the input password and compare with the stored hash
            Console.WriteLine("Hashed Input Password: " + HashPassword(loginDTO.Password)); // Debugging
            Console.WriteLine("Stored Password Hash: " + user.PasswordHash); // Debugging

            if (user.PasswordHash != HashPassword(loginDTO.Password))
            {
                return Unauthorized(new { message = "Invalid email or password." });
            }

            // Step 3: Successful login response
            return Ok(new { message = "Login successful.", userId = user.UserId });
        }

        // POST: api/Authentication/register
        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] RegisterDTO registerDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Step 1: Check if the email already exists
            var emailExists = await _context.Users.AnyAsync(u => u.Email.ToLower() == registerDTO.Email.ToLower());
            if (emailExists)
            {
                return Conflict(new { message = "Email already in use." });
            }

            // Step 2: Create a new User object with hashed password
            var user = new User
            {
                Username = registerDTO.Username,
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
                Email = registerDTO.Email,
                PasswordHash = HashPassword(registerDTO.Password), // Hashing the password before storing it
                AccountCreated = DateTime.UtcNow
            };

            // Step 3: Add the user to the database
            _context.Users.Add(user);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, new { message = "An error occurred while registering the user.", details = ex.Message });
            }

            // Step 4: Return success response
            return CreatedAtAction(nameof(Register), new { id = user.UserId }, new { message = "Registration successful.", userId = user.UserId });
        }
    }
}
