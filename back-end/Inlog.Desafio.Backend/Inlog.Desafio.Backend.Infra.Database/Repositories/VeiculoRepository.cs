﻿using Inlog.Desafio.Backend.Domain.Models;
using Inlog.Desafio.Backend.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlog.Desafio.Backend.Infra.Database.Repositories
{
	public class VeiculoRepository : IVeiculoRepository
	{
		private readonly VeiculoContext _context;

        public VeiculoRepository(VeiculoContext veiculoContext)
        {
            this._context = veiculoContext;
        }
        public Task Cadastrar(Veiculo veiculo)
		{
			_context.VeiculoDB.Add(veiculo);
			return _context.SaveChangesAsync();
		}

		public async Task<IList<Veiculo>> Listar()
		{
			return await _context.VeiculoDB.ToListAsync();
		}
	}
}