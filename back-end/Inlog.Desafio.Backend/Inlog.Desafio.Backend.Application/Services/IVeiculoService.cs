using Inlog.Desafio.Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlog.Desafio.Backend.Application.Services
{
	public interface IVeiculoService
	{
		Task Cadastrar(Veiculo veiculo);
		Task<IList<Veiculo>> Listar();
	}
}
