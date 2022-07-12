using AutoMapper;
using Automapping.DTO;
using Automapping.Todo;

namespace Automapping;

public class AutomappingApplicationAutoMapperProfile : Profile
{
    public AutomappingApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<TodoDto, Todos>().ReverseMap();
    }
}
