using rest_api_dotnet_template.Data;
using rest_api_dotnet_template.Models;
using rest_api_dotnet_template.Repositories;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BC = BCrypt.Net.BCrypt;

namespace rest_api_dotnet_template.Services
{
    public interface IDisciplinaService : IService<Disciplina>
    {
        Task<Disciplina> GetByEmailAsync(string email);

        Task RegisterAsync(Disciplina entity);

        Task<string> Authenticate(string email, string password);
    }

    public class DisciplinaService : Service<Disciplina, ApiDbContext>, IDisciplinaService
    {
        private readonly IDisciplinaRepository _userRepository;
        private readonly IConfiguration _configuration;

        public DisciplinaService(IDisciplinaRepository repository, IConfiguration configuration) : base(repository)
        {
            _userRepository = repository;
            _configuration = configuration;
        }

      
        }
    }
}
