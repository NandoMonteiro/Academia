using academia.Data;
using academia.Models;
using Microsoft.EntityFrameworkCore;

namespace academia.Repositories
{
    public interface IClienteRepository : IRepository<Cliente> {

    }
    
    public class ClienteRepository : Repository<Cliente, ApiDbContext>, IClienteRepository
    {
        public ClienteRepository(ApiDbContext context) : base(context) { }               
    }
}
