using Dapper;
using System.Data.Common;
using TechVoiture.Domain.Models;
using TechVoiture.Domain.Repositories;

namespace TechVoiture.DAL.Repositories
{
    public class EngineRepository : IEngineRepository
    {
        private readonly DbConnection _connection;

        public EngineRepository(DbConnection connection)
        {
            _connection = connection;
        }


        public Engine Create(Engine engine)
        {
            try
            {
                _connection.Open();

                // ADO / Dapper / EF -> Via les parametres SQL vous proteges de la faille "Injection SQL"
                Engine result = _connection.QuerySingle<Engine>(
                    "INSERT INTO [Engine]([Name], [Fuel])" +
                    " OUTPUT [inserted].*" +
                    " VALUES (@Name, @Fuel);", engine
                    );
                return result;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Engine? Find(int id)
        {
            try
            {
                _connection.Open();
                return _connection.QuerySingleOrDefault<Engine>(
                    "SELECT * FROM [engine] WHERE Id = @Id",
                    new { id }
                    );
            }
            finally { _connection.Close(); }
        }

        public IEnumerable<Engine> FindAll()
        {
            try
            {
                _connection.Open();
                return _connection.Query<Engine>("SELECT * FROM Engine");
            }
            finally { _connection.Close(); }
        }

        public Engine Update(Engine engine)
        {
            try
            {
                _connection.Open();
                Engine result = _connection.QuerySingle<Engine>(
                    "UPDATE [Engine]" +
                    " SET Name = @Name," +
                    "     Fuel = @Fuel" +
                    " OUTPUT inserted.*" +
                    " WHERE Id = @Id",
                    engine);
                return result;
            }
            finally { _connection.Close(); }
        }
    }
}
