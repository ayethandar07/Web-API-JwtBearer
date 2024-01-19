namespace JwtAPI.Models.DTO
{
    public class LoginResponse : Status
    {
        public string Token { get; set; }
        public string Refreshoken { get; set; }
        public DateTime? Expiration { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
    }
}
