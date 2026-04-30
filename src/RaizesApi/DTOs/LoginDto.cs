namespace RaizesApi.DTOs
{
    public class LoginDto
    {
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;

        public LoginDto()
        {

        }

        public LoginDto(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }        
    }
}
