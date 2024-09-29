
using academia.Services;
using academia.Models;


namespace academia.Controllers
{
    public class PagamentosController : BaseController<Pagamento, IPagamentoService>
    {
        public PagamentosController(IPagamentoService service) : base(service)
        {
        }
    }
}
