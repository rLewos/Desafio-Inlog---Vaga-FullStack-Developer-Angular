using Inlog.Desafio.Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlog.Desafio.Backend.Domain.Repositories
{
	public interface IVeiculoRepository : IBaseRepository<Veiculo>
	{
		Task Cadastrar(Veiculo veiculo);
		Task<IList<Veiculo>> Listar();
	}
}
