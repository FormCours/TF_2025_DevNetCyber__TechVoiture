using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TechVoiture.API.Dto.Input;
using TechVoiture.API.Dto.Output;

namespace TechVoiture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EngineController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType<IEnumerable<EngineOutputDTO>>(200)]
        public IActionResult GetAll()
        {
            // TODO Utilisation des services (BLL) pour obtenir les moteurs
            return StatusCode(501);
        }

        [HttpPost]
        [Consumes("application/json")]
        [ProducesResponseType<EngineDetailOutputDTO>(201)]
        [ProducesResponseType(400)]
        public IActionResult Add([FromBody] EngineInputDTO data)
        {
            // TODO Utilisation des services (BLL) pour ajouter un moteur
            return StatusCode(501);
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
