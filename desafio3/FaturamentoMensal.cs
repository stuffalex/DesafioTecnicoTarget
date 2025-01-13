using Newtonsoft.Json;

namespace DesafioTecnicoTarget.desafio3
{
    public class FaturamentoMensal
    {
        [JsonProperty("faturamentoMensal")]
        public List<FaturamentoDiario> Mensal { get; set; }
    }
}
