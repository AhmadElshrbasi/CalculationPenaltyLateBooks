using AutoMapper;
using SimpleTouchTask.Shared.Dtos;
using SimpleTouchTask.Shared.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimpleTouchTask.Server.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<LibraryCountry, LibraryCountryResponseDto>().ReverseMap();
        }
    }
}
