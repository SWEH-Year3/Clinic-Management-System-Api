using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ClinicAPI.Models.Domain;
using Microsoft.IdentityModel.Tokens;

namespace ClinicAPI.Repositories
{
    public class TokenRepository : ITokenRepository
    {
        private readonly IConfiguration configuration;

        public TokenRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public string CreateToken(UserApplication user, List<string> roles)
        {
            var cliams = new List<Claim>();
            cliams.Add(new Claim(ClaimTypes.Email, user.Email));
            foreach (var role in roles)
            {
                cliams.Add(new Claim(ClaimTypes.Role, role));

            }
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var Credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(configuration["Jwt:Issuer"], configuration["Jwt:Audience"]
               , cliams, expires: DateTime.Now.AddMinutes(15), signingCredentials: Credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
