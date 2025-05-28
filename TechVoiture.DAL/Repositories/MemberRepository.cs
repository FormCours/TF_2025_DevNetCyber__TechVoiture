using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVoiture.Domain.Models;
using TechVoiture.Domain.Repositories;

namespace TechVoiture.DAL.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly DbConnection _connection;

        public MemberRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public Member Create(Member member)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Member? Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> GetAll()
        {
            try
            {
                _connection.Open();
                return _connection.Query<Member,MemberRole,Member>(
                    "SELECT [M].Id, FirstName, LastName, Email, RoleId, [MR].* " +
                    "FROM Member As [M]" +
                    "JOIN MemberRole AS [MR] ON RoleId = MR.Id", (member, role) =>
                    {
                        member.Role = role;
                        return member;
                    });
            }
            finally { _connection.Close(); }
        }

        public Member Update(Member member)
        {
            throw new NotImplementedException();
        }
    }
}
