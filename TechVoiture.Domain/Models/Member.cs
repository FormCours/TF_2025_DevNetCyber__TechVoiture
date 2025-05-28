using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TechVoiture.Domain.Models
{
    public class Member
    {
        public int Id { get; set; }
        public required string Email { get; set; }
        public string? HashPassword { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public MemberRole? Role { get; set; }
    }
}
