namespace DesafioTecnicoTarget.desafio3;

public class Desafio3
{
    private const string json = @"{
        ""faturamentoMensal"": 
        [
            { ""dia"": 1, ""faturamento"": 0 },
            { ""dia"": 2, ""faturamento"": 2500.50 },
            { ""dia"": 3, ""faturamento"": 3100.75 },
            { ""dia"": 4, ""faturamento"": 0 },
            { ""dia"": 5, ""faturamento"": 4500.00 },
            { ""dia"": 6, ""faturamento"": 0 },
            { ""dia"": 7, ""faturamento"": 0 },
            { ""dia"": 8, ""faturamento"": 2200.30 },
            { ""dia"": 9, ""faturamento"": 3400.90 },
            { ""dia"": 10, ""faturamento"": 0 },
            { ""dia"": 11, ""faturamento"": 1250.00 },
            { ""dia"": 12, ""faturamento"": 0 },
            { ""dia"": 13, ""faturamento"": 0 },
            { ""dia"": 14, ""faturamento"": 0 },
            { ""dia"": 15, ""faturamento"": 2700.20 },
            { ""dia"": 16, ""faturamento"": 0 },
            { ""dia"": 17, ""faturamento"": 0 },
            { ""dia"": 18, ""faturamento"": 3800.60 },
            { ""dia"": 19, ""faturamento"": 0 },
            { ""dia"": 20, ""faturamento"": 4100.00 },
            { ""dia"": 21, ""faturamento"": 0 },
            { ""dia"": 22, ""faturamento"": 0 },
            { ""dia"": 23, ""faturamento"": 5000.00 },
            { ""dia"": 24, ""faturamento"": 4700.80 },
            { ""dia"": 25, ""faturamento"": 0 },
            { ""dia"": 26, ""faturamento"": 0 },
            { ""dia"": 27, ""faturamento"": 0 },
            { ""dia"": 28, ""faturamento"": 6000.90 },
            { ""dia"": 29, ""faturamento"": 0 },
            { ""dia"": 30, ""faturamento"": 3500.00 }
        ]
    }";
    public IList<FaturamentoDiario> Mensal;

    public void Deserializar()
    {
        var dados = Newtonsoft.Json.JsonConvert.DeserializeObject<FaturamentoMensal>(json);
        Mensal = dados?.Mensal ?? new List<FaturamentoDiario>();

        Console.WriteLine("Faturamento Mensal:");
        foreach (var item in Mensal)
        {
            Console.WriteLine($"Dia: {item.Dia}, Faturamento: {item.Faturamento}");
        }
    }

    public void MenorFaturamentoDoMes()
    {
        ValidacaoDeDados();
        var menorValor = Mensal.Where(m => m.Faturamento > 0).Min(m => m.Faturamento);
        var diaComMenorFaturamento = Mensal.First(d => d.Faturamento == menorValor);

        Console.WriteLine("Dia com menor faturamento: " + diaComMenorFaturamento.Dia);
        Console.WriteLine("Valor de menor faturamento: " + menorValor);
    }

    public void MaiorFaturamentoDoMes()
    {
        ValidacaoDeDados();

        var maiorValor = Mensal.Where(m => m.Faturamento > 0).Max(m => m.Faturamento);
        var diaComMaiorFaturamento = Mensal.First(m => m.Faturamento == maiorValor);

        Console.WriteLine("Dia com maior faturamento: " + diaComMaiorFaturamento.Dia);
        Console.WriteLine("Valor de maior faturamento: " + maiorValor);
    }


    public void QuantidadeDeDiasComFaturamentoMaiorQueAMedia()
    {
        ValidacaoDeDados();

        var diasComFaturamentoMaiorQueZero = Mensal.Where(m => m.Faturamento > 0).Count();
        var valorFaturantoTotal = Mensal.Sum(m => m.Faturamento);
        var media = valorFaturantoTotal / diasComFaturamentoMaiorQueZero;
        var diasComValorMaiorQueAMedia = Mensal.Count(m => m.Faturamento >= media);

        Console.WriteLine("Media de faturamento: " + media);
        Console.WriteLine("Quantidade de dias com faturamento maior que a media: " + diasComValorMaiorQueAMedia);
    }

    private void ValidacaoDeDados()
    {
        if (Mensal == null || !Mensal.Any())
        {
            Console.WriteLine("Os dados ainda não foram carregados.");
            return;
        }
    }
}