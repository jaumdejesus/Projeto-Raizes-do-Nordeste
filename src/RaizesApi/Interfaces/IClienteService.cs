using Application.DTOs;
using RaizesApi.Services;

namespace RaizesApi.Interfaces
{
    public interface IClienteService
    {
        Task<ServiceResult> Cadastrar(ClienteDTO cliente);
    }
}
