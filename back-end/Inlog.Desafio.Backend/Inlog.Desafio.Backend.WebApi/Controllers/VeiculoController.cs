using Inlog.Desafio.Backend.Application.Services;
using Inlog.Desafio.Backend.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inlog.Desafio.Backend.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class VeiculoController : ControllerBase
{
    private readonly ILogger<VeiculoController> _logger;
    private readonly IVeiculoService _veiculoService;

    public VeiculoController(ILogger<VeiculoController> logger, IVeiculoService veiculoService)
    {
        _logger = logger;
		_veiculoService = veiculoService;

	}

    [HttpPost("Cadastrar")]
    public async Task<IActionResult> Cadastrar([FromBody] object dadosDoVeiculo)
    {
		Veiculo veiculo = new Veiculo()
		{
			Cor = "Azul",
			TipoVeiculo = TipoVeiculo.Caminhao,
            Chassi = "BNN",


			Identificador = "Veiculo 1",
			Placa = "AAA-9A99",
			NumeroRastreio = "A0000000",
			Longitude = "-25.43247",
			Latitude = "-49.27845",
		}; // TROCAR DTO

		await _veiculoService.Cadastrar(veiculo);

        return Ok();
    }

    [HttpGet("Listar")]
    public async Task<IActionResult> ListarVeiculosAsync()
    {
        IList<Veiculo> veiculoList = await _veiculoService.Listar();
        return Ok(veiculoList); // trocar para DTO
    }
}

