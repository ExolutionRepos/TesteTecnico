using AutoMapper;
using TesteTecnico.Api.DTOs.Enums;
using TesteTecnico.Api.DTOs.Request;
using TesteTecnico.Api.Models.Creditos;
using TesteTecnico.Api.Models.Creditos.Abstract;
using TesteTecnico.Api.Models.Enums;

namespace TesteTecnico.Api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<CreditoRequestDTO, Credito>().ReverseMap()
                .IgnoreAllPropertiesWithAnInaccessibleSetter();

            CreateMap<TipoCreditoDto, TipoCredito>().ReverseMap();
        }
    }
}
