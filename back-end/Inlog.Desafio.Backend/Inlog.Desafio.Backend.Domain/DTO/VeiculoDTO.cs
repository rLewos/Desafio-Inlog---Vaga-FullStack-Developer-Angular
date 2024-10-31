using Inlog.Desafio.Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlog.Desafio.Backend.Domain.DTO
{
	// Mudar para RECORD
	public record VeiculoDTO
	{
		public string Chassi { get; set; }
		public TipoVeiculo TipoVeiculo { get; set; }
		public string Cor { get; set; }

		public string Identificador { get; set; }
		public string Placa { get; set; }
		public string NumeroRastreio { get; set; }
		public string Longitude { get; set; }
		public string Latitude { get; set; }
	}
}
