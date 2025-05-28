using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechVoiture.API.Dto.Input;
using TechVoiture.API.Dto.Output;
using TechVoiture.API.Mappers;
using TechVoiture.BLL.Services;
using TechVoiture.Domain.Models;

namespace TechVoiture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class MemberController : ControllerBase
    {
        private readonly MemberService _memberService;
        private readonly IMapper _mapper;

        public MemberController(MemberService memberService, IMapper mapper)
        {
            _memberService = memberService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType<IEnumerable<MemberOutputDTO>>(200)]
        public IActionResult GetAll()
        {
            IEnumerable<Member> members = _memberService.GetAll();

            var map = _mapper.Map<IEnumerable<MemberOutputDTO>>(members);
            return Ok(map);
        }

        [HttpGet("{id :int}")]
        [ProducesResponseType<MemberDetailOutputDTO>(200)]
        [ProducesResponseType(404)]
        public IActionResult GetById([FromRoute]int id)
        {
            return StatusCode(501);
        }

        [HttpPut("{id :int}")]
        [ProducesResponseType<MemberDetailOutputDTO>(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        [Consumes("application/json")]
        public IActionResult Update([FromRoute]int id, [FromBody]EngineInputDTO data)
        {   
            return StatusCode(501);
        }   
    }
       
}
    

