using Inlog.Desafio.Backend.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Inlog.Desafio.Backend.Infra.Database
{
	public class VeiculoContext : DbContext
	{
        public DbSet<Veiculo> VeiculoDB { get; set; }
  
		public VeiculoContext(DbContextOptions options) : base(options)
		{
		}
	}
}
