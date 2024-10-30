using Inlog.Desafio.Backend.Application.Services;
using Inlog.Desafio.Backend.Domain.Repositories;
using Inlog.Desafio.Backend.Infra.Database;
using Inlog.Desafio.Backend.Infra.Database.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlog.Desafio.Backend.Test
{
	internal class ServiceFactory
	{
		private static ServiceCollection services;

		private static IServiceProvider GetServiceProvider()
		{
			services = new ServiceCollection();
			services.AddScoped<IVeiculoService, VeiculoService>();
			services.AddScoped<IVeiculoRepository, VeiculoRepository>();

			string connectionString = "Host=localhost;Port=5432;Database=desafioVeiculo;User Id=postgres;Password=yourStrong(!)Password;";
			services.AddDbContext<VeiculoContext>(opt => opt.UseNpgsql(connectionString));

			ServiceProvider serviceProvider = services.BuildServiceProvider();

			return serviceProvider;
		}

		public static T GetService<T>()
		{
			return GetServiceProvider().GetRequiredService<T>();
		}
	}

}