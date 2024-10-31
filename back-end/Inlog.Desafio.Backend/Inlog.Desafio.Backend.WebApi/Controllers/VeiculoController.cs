using AutoMapper;
using Inlog.Desafio.Backend.Application.Services;
using Inlog.Desafio.Backend.Domain.Models;
using Inlog.Desafio.Backend.Domain.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Inlog.Desafio.Backend.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class VeiculoController : ControllerBase
{
    private readonly ILogger<VeiculoController> _logger;
    private readonly IVeiculoService _veiculoService;
    private readonly IMapper _mapper;

    public VeiculoController(ILogger<VeiculoController> logger, IVeiculoService veiculoService, IMapper mapper)
    {
        _logger = logger;
		_veiculoService = veiculoService;
        _mapper = mapper;

	}

    [HttpPost("Cadastrar")]
    public async Task<IActionResult> Cadastrar([FromBody] VeiculoDTO veiculoDTO)
    {
		Veiculo veiculo = _mapper.Map<Veiculo>(veiculoDTO);
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

