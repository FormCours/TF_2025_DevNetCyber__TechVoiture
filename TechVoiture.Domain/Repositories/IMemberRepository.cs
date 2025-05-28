using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVoiture.Domain.Models;

namespace TechVoiture.Domain.Repositories
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetAll();
        Member? Find(int id);
        Member Create(Member member);
        Member Update(Member member);
        bool Delete(int id);
    }
}
