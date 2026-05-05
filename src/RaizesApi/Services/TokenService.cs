namespace RaizesApi.Services;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RaizesApi.DTOs;
using RaizesApi.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

internal class TokenService : IToken
{
    private readonly string _key;
    public TokenService(IConfiguration configuration)
    {
        _key = configuration["Jwt:Key"];
    }
    public string Generate(LoginDto login)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_key); 
        var tokenDescriptor = new SecurityTokenDescriptor 
        {            
            Subject = GenerateClaims(login),
            Expires = DateTime.UtcNow.AddMinutes(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    private static ClaimsIdentity GenerateClaims(LoginDto login)
    {
        var ci = new ClaimsIdentity();
        ci.AddClaim(new Claim(ClaimTypes.Email, login.Email));
        ci.AddClaim(new Claim(ClaimTypes.Role, login.Cargo));

        return ci;
    }
}

