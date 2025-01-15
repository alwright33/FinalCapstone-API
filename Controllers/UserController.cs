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
    public class UsersController : ControllerBase
    {
        private readonly CookistryDbContext _context;

        public UsersController(CookistryDbContext context)
        {
            _context = context;
        }

        private static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password)));
        }

        private static UserDTO MapToUserDTO(User user)
        {
            return new UserDTO
            {
                UserId = user.UserId,
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                AccountCreated = user.AccountCreated
            };
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers()
        {
            try
            {
                var users = await _context.Users
                    .Select(user => MapToUserDTO(user))
                    .ToListAsync();

                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving users.", details = ex.Message });
            }
        }

        // GET: api/Users/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound(new { message = "User not found." });
            }

            return Ok(MapToUserDTO(user));
        }

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<UserDTO>> CreateUser([FromBody] CreateUserDTO createUserDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new User
            {
                Username = createUserDTO.Username,
                FirstName = createUserDTO.FirstName,
                LastName = createUserDTO.LastName,
                Email = createUserDTO.Email,
                PasswordHash = HashPassword(createUserDTO.Password),
                AccountCreated = DateTime.UtcNow
            };

            _context.Users.Add(user);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, new { message = "An error occurred while creating the user.", details = ex.Message });
            }

            return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, MapToUserDTO(user));
        }

        // PUT: api/Users/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UserDTO updatedUserDTO)
        {
            if (id != updatedUserDTO.UserId)
            {
                return BadRequest(new { message = "User ID mismatch." });
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound(new { message = "User not found." });
            }

            user.Username = updatedUserDTO.Username;
            user.FirstName = updatedUserDTO.FirstName;
            user.LastName = updatedUserDTO.LastName;
            user.Email = updatedUserDTO.Email;

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Users.Any(u => u.UserId == id))
                {
                    return NotFound(new { message = "User not found." });
                }

                throw;
            }

            return NoContent();
        }

        // DELETE: api/Users/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound(new { message = "User not found." });
            }

            _context.Users.Remove(user);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while deleting the user.", details = ex.Message });
            }

            return NoContent();
        }
    }
}
