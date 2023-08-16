using System.ComponentModel.DataAnnotations;

namespace JWTAuth.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        public string userName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
