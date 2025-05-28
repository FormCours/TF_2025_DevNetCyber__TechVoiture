using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TechVoiture.API.Dto.Input;
using TechVoiture.API.Dto.Output;
using TechVoiture.BLL.Services;
using TechVoiture.Domain.Models;

namespace TechVoiture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EngineController : ControllerBase
    {
        private readonly EngineService _engineService;
        private readonly IMapper _mapper;

        public EngineController(EngineService engineService, IMapper mapper)
        {
            _engineService = engineService;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType<IEnumerable<EngineOutputDTO>>(200)]
        public IActionResult GetAll()
        {
            IEnumerable<Engine> engines = _engineService.GetAll();

            var test1 = engines.Select(engine => _mapper.Map<EngineOutputDTO>(engine));
            var test2 = _mapper.Map<IEnumerable<EngineOutputDTO>>(engines);

            return Ok(test2);
        }

        [HttpPost]
        [Consumes("application/json")]
        [ProducesResponseType<EngineDetailOutputDTO>(201)]
        [ProducesResponseType(400)]
        public IActionResult Add([FromBody] EngineInputDTO data)
        {
            Engine result = _engineService.Create(_mapper.Map<Engine>(data));
        
            EngineOutputDTO responseData = _mapper.Map<EngineOutputDTO>(result);
            return CreatedAtAction(nameof(GetAll), responseData);
        }

        [HttpPut("{id:int}")]
        [Consumes("application/json")]
        [ProducesResponseType<EngineDetailOutputDTO>(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult Update([FromRoute] int id, [FromBody] EngineInputDTO data)
        {
            // TODO Utilisation des services (BLL) pour modifier un moteur
            return StatusCode(501);
        }
    }
}
