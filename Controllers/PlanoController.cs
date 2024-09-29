
using academia.Services;
using academia.Models;


namespace academia.Controllers
{
    public class PlanosController : BaseController<Plano, IPlanoService>
    {
        public PlanosController(IPlanoService service) : base(service)
        {
        }
    }
}
