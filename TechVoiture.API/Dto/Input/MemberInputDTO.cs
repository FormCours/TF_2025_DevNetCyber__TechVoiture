namespace TechVoiture.API.Dto.Input
{
    public class MemberInputDTO
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
    }

    public class MemberRegisterInputDTO
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }

    }
}
