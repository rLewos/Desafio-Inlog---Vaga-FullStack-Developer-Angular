using AutoMapper;
using Inlog.Desafio.Backend.Domain.Models;
using Inlog.Desafio.Backend.Domain.DTO;

namespace Inlog.Desafio.Backend.Application.Mappers
{
	public class VeiculoVeiculoDTO : Profile
	{
        public VeiculoVeiculoDTO()
        {
            CreateMap<VeiculoDTO, Veiculo>();
            CreateMap<Veiculo, VeiculoDTO>();
        }
    }
}
