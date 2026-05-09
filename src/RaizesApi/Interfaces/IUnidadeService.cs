using Application.DTOs;
using RaizesApi.Services;

namespace RaizesApi.Interfaces
{
    public interface IUnidadeService
    {
        Task<ServiceResult> Criar(UnidadeDTO unidade);
    }
}
