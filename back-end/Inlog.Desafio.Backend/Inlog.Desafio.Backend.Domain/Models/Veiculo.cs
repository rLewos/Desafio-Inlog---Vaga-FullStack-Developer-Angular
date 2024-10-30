namespace Inlog.Desafio.Backend.Domain.Models;

public class Veiculo
{
	public int Codigo { get; set; }
    public string Chassi { get; set; }
    public TipoVeiculo TipoVeiculo { get; set; }
    public string Cor { get; set; }

    public string Identificador { get; set; }
    public string Placa { get; set; }
    public string NumeroRastreio { get; set; }
    public string Longitude { get; set; }
    public string Latitude { get; set; }
}
