using Isopoh.Cryptography.Argon2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVoiture.Domain.Models;
using TechVoiture.Domain.Repositories;

namespace TechVoiture.BLL.Services
{
    public class AuthService
    {
        private readonly IMemberRepository _memberRepository;

        public AuthService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public bool CreateMember(Member member)
        {
            try
            {
                Member data = new Member()
                {
                    Id = member.Id,
                    Email = member.Email.ToLower(),
                    FirstName = member.FirstName,
                    LastName = member.LastName,
                    HashPassword = Argon2.Hash(member.HashPassword),
                    Role = new MemberRole() { Name = "Member", Id = 1 },
                };

                _memberRepository.Create(data);
                return true;
            }
            catch (Exception ex)
            {
                // Logger d'exception
                return false;
            }
        }
    }
}
