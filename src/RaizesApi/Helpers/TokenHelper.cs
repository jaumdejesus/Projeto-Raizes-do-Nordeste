using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace RaizesApi.Helpers
{
    internal static class TokenHelper
    {
        public static TokenValidationParameters GetTokenValidationParameters(IConfiguration configuration)
        {
            var key = Encoding.UTF8.GetBytes(configuration["Jwt:Key"]);

            return new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key), // Substitua por uma chave secreta forte
                ClockSkew = TimeSpan.Zero
            };
        }
    }
}
