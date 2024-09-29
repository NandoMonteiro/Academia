
using academia.Services;
using academia.Models;


namespace academia.Controllers
{
    public class ClientesController : BaseController<Cliente, IClienteService>
    {
        public ClientesController(IClienteService service) : base(service)
        {
        }
    }
}
