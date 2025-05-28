using TechVoiture.Domain.Models;
using TechVoiture.Domain.Repositories;

namespace TechVoiture.BLL.Services
{
    public class EngineService
    {
        private readonly IEngineRepository _engineRepository;

        public EngineService(IEngineRepository engineRepository)
        {
            _engineRepository = engineRepository;
        }


        public Engine Create(Engine data)
        { 
            if(data.Name.Contains("Puretech", StringComparison.InvariantCultureIgnoreCase))
            {
                throw new Exception("Moteur Puretech non autorisé...");
            }

            return _engineRepository.Create(data);
        }

        public IEnumerable<Engine> GetAll()
        {
            return _engineRepository.FindAll();
        }
    }
}
