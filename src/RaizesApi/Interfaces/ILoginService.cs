using RaizesApi.DTOs;

namespace RaizesApi.Interfaces
{
    public interface ILoginService
    {
        Task LoginValidate(LoginDto login);
    }
}
