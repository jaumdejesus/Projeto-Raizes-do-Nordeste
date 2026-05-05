using RaizesApi.DTOs;
using RaizesApi.Models;

namespace RaizesApi.Interfaces
{
    public interface IRegisterRepository
    {
        Task<bool> Register(UsuarioLogin user);       
    }
}
