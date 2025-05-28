using TechVoiture.Domain.Exceptions;
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

private bool CheckEngineName(Engine engine)
        {
            return engine.Name.Contains("Puretech", StringComparison.InvariantCultureIgnoreCase);
        }


        public Engine Create(Engine data)
        { 
            if (CheckEngineName(data))
            {
                throw new InvalidValueException("name", "Création de moteur Puretech non autorisé !");
            }

            return _engineRepository.Create(data);
        }

        public IEnumerable<Engine> GetAll()
        {
            return _engineRepository.FindAll();
        }
    }
}
