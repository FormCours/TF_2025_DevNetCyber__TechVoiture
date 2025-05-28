using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechVoiture.API.Dto.Input;
using TechVoiture.BLL.Services;
using TechVoiture.Domain.Models;

namespace TechVoiture.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }


        [HttpPost("register")]
        public IActionResult Register(MemberRegisterInputDTO data)
        {
            bool accountCreated = _authService.CreateMember(new Member
            {
                Id = 0,
                Email = data.Email,
                FirstName = data.FirstName,
                LastName = data.LastName,
                HashPassword = data.Password,
                Role = null,
            });

            return StatusCode(accountCreated ? 204 : 400);
        }
    }
}