using Newtonsoft.Json;

namespace DesafioTecnicoTarget.desafio3;
public class FaturamentoDiario
{
    [JsonProperty("dia")]
    public int Dia { get; set; }
    [JsonProperty("valor")]
    public double Valor { get; set; }
}
