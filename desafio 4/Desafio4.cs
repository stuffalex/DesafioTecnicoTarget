namespace DesafioTecnicoTarget.desafio_4
{
    public class Desafio4
    {
        public IList<FaturamentoEstado> Faturamentos;
        //        4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
        //• SP – R$67.836,43
        //• RJ – R$36.678,66
        //• MG – R$29.229,88
        //• ES – R$27.165,48
        //• Outros – R$19.849,53

        //Escreva um programa na linguagem que desejar onde calcule o percentual
        //de representação que cada estado teve dentro do valor total mensal da distribuidora.
        public void MontaFaturamentos()
        {
            Faturamentos = new List<FaturamentoEstado>();
            Faturamentos.Add(new FaturamentoEstado("SP", 67836.43));
            Faturamentos.Add(new FaturamentoEstado("RJ", 36678.66));
            Faturamentos.Add(new FaturamentoEstado("MG", 29229.88));
            Faturamentos.Add(new FaturamentoEstado("Outros", 19849.53));

            Console.WriteLine("Faturamento Mensal:");
            foreach (var item in Faturamentos)
            {
                Console.WriteLine($"UF: {item.UF}, Faturamento: {item.Faturamento}");
            }
            Console.WriteLine(" ");
        }

        private double CalculaTotalDeFaturamento()
        {
            var valorTotal = Faturamentos.Sum(f => f.Faturamento);
            return valorTotal;
        }

        public void CalculaPercentualPorEstado()
        {
            var valorTotal = CalculaTotalDeFaturamento();
            foreach(var item in Faturamentos)
            {
                var percentual = (item.Faturamento / valorTotal) * 100;

                Console.WriteLine("Estado:" + item.UF);
                Console.WriteLine("Percentual: " + Math.Round(percentual, 2));
                Console.WriteLine(" ");
            }
        }
    }
}
