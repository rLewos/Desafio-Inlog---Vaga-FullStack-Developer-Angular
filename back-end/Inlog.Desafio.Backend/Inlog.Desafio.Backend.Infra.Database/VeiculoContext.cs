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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			var entity = modelBuilder.Entity<Veiculo>();
			entity.HasKey(v => v.Codigo);

			entity.Property(v=>v.Chassi);
			entity.Property(v => v.TipoVeiculo); 
			entity.Property(v => v.Cor);

			entity.Property(v => v.Identificador);
			entity.Property(v => v.Placa);
			entity.Property(v => v.NumeroRastreio);
			entity.Property(v => v.Longitude);
			entity.Property(v => v.Latitude);
	}
	}
}
