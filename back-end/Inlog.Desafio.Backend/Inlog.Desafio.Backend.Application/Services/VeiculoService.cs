using Inlog.Desafio.Backend.Domain.Models;
using Inlog.Desafio.Backend.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlog.Desafio.Backend.Application.Services
{
	public class VeiculoService : IVeiculoService
	{
		private readonly IVeiculoRepository _repository;
        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
			_repository = veiculoRepository;

		}

        public async Task Cadastrar(Veiculo veiculo)
		{
			await _repository.Cadastrar(veiculo);
		}

		public async Task<IList<Veiculo>> Listar()
		{
			return await _repository.Listar();
		}
	}
}
