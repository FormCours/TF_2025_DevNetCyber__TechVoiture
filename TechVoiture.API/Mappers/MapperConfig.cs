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

            CreateMap<MemberInputDTO, Member>();
            CreateMap<Member, MemberOutputDTO>().ForMember(output=> output.Role,config => config.MapFrom(member => member.Role.Name));
            CreateMap<Member, MemberDetailOutputDTO>().ForMember(output => output.Role, config => config.MapFrom(member => member.Role.Name));
        }
    }
}
