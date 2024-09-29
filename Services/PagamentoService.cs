using academia.Data;
using academia.Models;
using academia.Repositories;


namespace academia.Services
{
    public interface IPagamentoService : IService<Pagamento> {

    }

    public class PagamentoService : Service<Pagamento, ApiDbContext>, IPagamentoService
    {
    

        public PagamentoService(IPagamentoRepository repository) : base(repository)
        {
   
        }


    }
}
