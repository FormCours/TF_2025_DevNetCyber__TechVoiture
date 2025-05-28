using Microsoft.AspNetCore.Identity;

namespace TechVoiture.API.Dto.Output
{
    public class MemberOutputDTO
    {
        public int Id { get; set; }

        public required string Email { get; set; }

        public required string Role {  get; set; }
    }

    public class MemberDetailOutputDTO
    {
        public int Id { get; set; }

        public required string Email { get; set; }

        public required string Role { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
    }
}
