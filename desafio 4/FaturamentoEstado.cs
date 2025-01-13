namespace DesafioTecnicoTarget.desafio_4
{
    public class FaturamentoEstado
    {
        public string UF { get; protected set; }
        public double Faturamento { get; protected set; }

        public FaturamentoEstado(string uf, double faturamento)
        {
            UF = uf;
            Faturamento = faturamento;  
        }
    }
}
