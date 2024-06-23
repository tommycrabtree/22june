using System.ComponentModel.DataAnnotations;

namespace api.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
