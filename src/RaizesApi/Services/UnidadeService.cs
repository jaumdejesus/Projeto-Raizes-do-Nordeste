using Application.DTOs;
using RaizesApi.Interfaces;

namespace RaizesApi.Services
{
    internal class UnidadeService : IUnidadeService
    {
        private readonly IUnidadeRepository _unidadeRepository;
        public UnidadeService(IUnidadeRepository unidadeRepository)
        {
            _unidadeRepository = unidadeRepository;
        }
        public async Task<ServiceResult> Criar(UnidadeDTO unidade)
        {
            Unidade novaUnidade = Unidade.NovaUnidade(unidade);
            if(await _unidadeRepository.Criar(novaUnidade))
            {
                return ServiceResult.Ok(); 
            }

            return ServiceResult.Fail("Erro ao criar unidade");
        }
    }
}
