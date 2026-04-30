namespace RaizesApi.Services;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RaizesApi.DTOs;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

public class TokenService
{
    public string Gerar(LoginDto login)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes("vaQUJRhV8Xf2FEnC56TqrL86UyLSg2QN0zSZrkf8c6b"); // Substitua por uma chave secreta forte
        var tokenDescriptor = new SecurityTokenDescriptor 
        {            
            Subject = GenerateClaims(login),
            Expires = DateTime.UtcNow.AddMinutes(15), // Define a expiração do token
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    private static ClaimsIdentity GenerateClaims(LoginDto login)
    {
        var ci = new ClaimsIdentity();
        ci.AddClaim(new Claim(ClaimTypes.Email, login.Email));       

        return ci;
    }
}

