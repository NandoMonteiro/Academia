using academia.Data;
using academia.Models;
using Microsoft.EntityFrameworkCore;

namespace academia.Repositories
{
    public interface IPlanoRepository : IRepository<Plano> {

    }
    
    public class PlanoRepository : Repository<Plano, ApiDbContext>, IPlanoRepository
    {
        public PlanoRepository(ApiDbContext context) : base(context) { }               
    }
}
