using academia.Data;
using academia.Models;
using academia.Repositories;


namespace academia.Services
{
    public interface IClienteService : IService<Cliente> {

    }

    public class ClienteService : Service<Cliente, ApiDbContext>, IClienteService
    {
    

        public ClienteService(IClienteRepository repository) : base(repository)
        {
   
        }


    }
}
