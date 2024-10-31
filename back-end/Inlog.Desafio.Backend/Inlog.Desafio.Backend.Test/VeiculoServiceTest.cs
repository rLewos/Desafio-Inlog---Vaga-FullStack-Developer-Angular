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
            _veiculoService = ServiceFactory.GetService<IVeiculoService>();
        }

        [Fact]
        public async Task Cadastrar()
        {
            // Arrange
            Veiculo veiculo = new Veiculo()
            {
				Chassi = "BNNv2",
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
			var list = await _veiculoService.Listar();
			Veiculo veiculoRetorno = list.FirstOrDefault(x => x.Codigo == veiculo.Codigo);

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
