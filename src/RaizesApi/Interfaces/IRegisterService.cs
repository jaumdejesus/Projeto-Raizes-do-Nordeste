using RaizesApi.DTOs;
using RaizesApi.Services;

namespace RaizesApi.Interfaces
{
    public interface IRegisterService
    {
        Task<ServiceResult> Register(RegisterDTO register);
    }
}
