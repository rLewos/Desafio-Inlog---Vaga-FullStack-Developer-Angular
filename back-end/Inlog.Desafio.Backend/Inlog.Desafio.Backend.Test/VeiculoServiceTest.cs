using Inlog.Desafio.Backend.Application.Services;
using Inlog.Desafio.Backend.Domain.Models;
using Xunit;

namespace Inlog.Desafio.Backend.Test
{
	public class VeiculoServiceTest
	{
        private readonly IVeiculoService _veiculoService;

        public VeiculoServiceTest()
        {
            this._veiculoService = ServiceFactory.GetService<IVeiculoService>();
        }

        [Fact]
        public async Task Cadastrar()
        {
            // Arrange
            Veiculo veiculo = new Veiculo()
            {
                Cor = "Azul",
                Identificador = "Veiculo 1",
                Placa = "AAA-9A99",
				NumeroRastreio = "A0000000",
				Longitude = "-25.43247",
				Latitude = "-49.27845",
                TipoVeiculo = TipoVeiculo.Caminhao
			};

            // Act
            await _veiculoService.Cadastrar(veiculo);

			// Asset
            Veiculo veiculoRetorno = new Veiculo();
			Assert.Equal(veiculo.Codigo, veiculoRetorno.Codigo);
        }

        [Fact]
        public async Task Listar()
        {
            var list = await _veiculoService.Listar();
            Assert.NotEmpty(list);
        }
    }
}
