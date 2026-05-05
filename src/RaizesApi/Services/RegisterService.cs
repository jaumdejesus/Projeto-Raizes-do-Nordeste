using Microsoft.EntityFrameworkCore.Internal;
using RaizesApi.DTOs;
using RaizesApi.Interfaces;
using RaizesApi.Models;
using RaizesApi.Repositories;

namespace RaizesApi.Services
{
    internal class RegisterService : IRegisterService
    {
        private readonly IRegisterRepository registerRepository;
        public RegisterService(IRegisterRepository repository)
        {
            registerRepository = repository;
        }        

        public async Task<ServiceResult> Register(RegisterDTO register)
        {
            var user = UsuarioLogin.Create(register);

            if(await registerRepository.Register(user))
                return ServiceResult.Ok();

            return ServiceResult.Fail("Erro ao registrar usuário!");
        }
    }
}
