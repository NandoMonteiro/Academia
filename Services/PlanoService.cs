using academia.Data;
using academia.Models;
using academia.Repositories;


namespace academia.Services
{
    public interface IPlanoService : IService<Plano> {

    }

    public class PlanoService : Service<Plano, ApiDbContext>, IPlanoService
    {
    

        public PlanoService(IPlanoRepository repository) : base(repository)
        {
   
        }


    }
}
