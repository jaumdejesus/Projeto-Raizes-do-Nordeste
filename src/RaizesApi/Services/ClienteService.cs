using Application.DTOs;
using RaizesApi.Interfaces;

namespace RaizesApi.Services
{
    internal class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;
        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public async Task<ServiceResult> Cadastrar(ClienteDTO cliente)
        {            
            var answer = await _repository.Criar(Cliente.Criar(cliente));
            return answer ? ServiceResult.Ok() : 
                ServiceResult.Fail("Não foi possível cadastrar o cliente no momento!");
        }
    }
}
