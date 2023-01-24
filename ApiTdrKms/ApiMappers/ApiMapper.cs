using ApiTdrKms.Modelos;
using ApiTdrKms.Modelos.Dtos;
using AutoMapper;

namespace ApiTdrKms.ApiMapper
{
    public class ApiMapper : Profile
    {
        public ApiMapper()
        {
            CreateMap<Distancia, DistanciaDto>().ReverseMap();
        }
    }
}
