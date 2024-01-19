using JwtAPI.Models.DTO;
using System.Security.Claims;

namespace JwtAPI.Repositories.Abstract
{
    public interface ITokenService
    {
        TokenResponse GetToken(IEnumerable<Claim> claims);

        string GetRefreshToken();

        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
