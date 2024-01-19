using System.ComponentModel.DataAnnotations;

namespace JwtAPI.Models.DTO
{
    public class RegistrationModel
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Usename { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
