using RaizesApi.Data;

namespace RaizesApi.Interfaces
{
    public interface IUnidadeRepository
    {
        Task<bool> Criar(Unidade unidade);
    }
}
