namespace RaizesApi.Interfaces
{
    public interface IClienteRepository
    {
        Task<bool> Criar(Cliente cliente);
    }
}
