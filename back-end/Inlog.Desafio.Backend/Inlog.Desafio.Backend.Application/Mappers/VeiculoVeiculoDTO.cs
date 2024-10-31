using AutoMapper;
using Inlog.Desafio.Backend.Domain.Models;
using Inlog.Desafio.Backend.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
