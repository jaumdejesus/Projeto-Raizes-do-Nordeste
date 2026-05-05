using RaizesApi.DTOs;

namespace RaizesApi.Interfaces
{
    public interface IToken
    {
        string Generate(LoginDto login);
    }
}
