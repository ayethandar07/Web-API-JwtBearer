using System.ComponentModel.DataAnnotations;

namespace JwtAPI.Models.DTO
{
    public class LoginModel
    {
        [Required]
        public string? Usename { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
