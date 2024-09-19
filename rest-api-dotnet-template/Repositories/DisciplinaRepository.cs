using rest_api_dotnet_template.Data;
using rest_api_dotnet_template.Models;
using Microsoft.EntityFrameworkCore;
using rest_api_dotnet_template.Models;

namespace rest_api_dotnet_template.Repositories
{
    public interface IDisciplinaRepository : IRepository<Disciplina>
    {
       
    }
    
    public class DisciplinaRepository : Repository<Disciplina, ApiDbContext>, IDisciplinaRepository
    {
        public DisciplinaRepository(ApiDbContext context) : base(context) { }

        
        
    }
}
