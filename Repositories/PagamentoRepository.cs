using academia.Data;
using academia.Models;
using Microsoft.EntityFrameworkCore;

namespace academia.Repositories
{
    public interface IPagamentoRepository : IRepository<Pagamento> {

    }
    
    public class PagamentoRepository : Repository<Pagamento, ApiDbContext>, IPagamentoRepository
    {
        public PagamentoRepository(ApiDbContext context) : base(context) { }               
    }
}
