using AutoMapper;
using TechVoiture.API.Dto.Input;
using TechVoiture.API.Dto.Output;
using TechVoiture.Domain.Models;

namespace TechVoiture.API.Mappers
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            // Mapper Engine
            CreateMap<EngineInputDTO, Engine>();
            CreateMap<Engine, EngineOutputDTO>();
            CreateMap<Engine, EngineDetailOutputDTO>();
        }
    }
}
