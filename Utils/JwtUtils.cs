using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using idflApp.Core.Dtos;
using idflApp.Core.Models;
using idflApp.Repository;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace idflApp.Utils
{
    public class JwtUtils : IJwtUtilRepository
    {
        private readonly AppSettings _appSettings;
        public JwtUtils(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;

            if (string.IsNullOrEmpty(_appSettings.Secret))
                throw new Exception("JWT secret not configured");
        }
        public string GenerateJwtToken(UserModel user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret!);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("id", user.Id.ToString()),
                }),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public Guid? ValidateJwtToken(string? token)
        {
            if (token == null)
            return null;
            var tokenHandler = new JwtSecurityTokenHandler();
            var key =  Encoding.ASCII.GetBytes(_appSettings.Secret!);
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters{
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero,

                }, out SecurityToken validatedToken);
                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = Guid.Parse(jwtToken.Claims.First(x=>x.Type == "id").Value);
                return userId;
            }
            catch (System.Exception)
            {
                
                return null;
            }
        }

    }
}