using Newtonsoft.Json;

namespace DesafioTecnicoTarget.desafio3;
public class FaturamentoDiario
{
    [JsonProperty("dia")]
    public int Dia { get; set; }
    [JsonProperty("faturamento")]
    public double Faturamento { get; set; }
}
