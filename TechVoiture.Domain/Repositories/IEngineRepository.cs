using TechVoiture.Domain.Models;

namespace TechVoiture.Domain.Repositories
{
    public interface IEngineRepository
    {
        IEnumerable<Engine> FindAll();
        Engine? Find(int id);
        Engine Create(Engine engine);
        Engine Update(Engine engine);
        bool Delete(int id);
    }
}
