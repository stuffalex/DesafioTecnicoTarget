namespace DesafioTecnicoTarget.desafio3;

public class Desafio3
{
    private const string json = @"{
        ""faturamentoMensal"": [
	{
		""dia"": 1,
		""valor"": 22174.1664
	},
	{
		""dia"": 2,
		""valor"": 24537.6698
	},
	{
		""dia"": 3,
		""valor"": 26139.6134
	},
	{
		""dia"": 4,
		""valor"": 0.0
	},
	{
		""dia"": 5,
		""valor"": 0.0
	},
	{
		""dia"": 6,
		""valor"": 26742.6612
	},
	{
		""dia"": 7,
		""valor"": 0.0
	},
	{
		""dia"": 8,
		""valor"": 42889.2258
	},
	{
		""dia"": 9,
		""valor"": 46251.174
	},
	{
		""dia"": 10,
		""valor"": 11191.4722
	},
	{
		""dia"": 11,
		""valor"": 0.0
	},
	{
		""dia"": 12,
		""valor"": 0.0
	},
	{
		""dia"": 13,
		""valor"": 3847.4823
	},
	{
		""dia"": 14,
		""valor"": 373.7838
	},
	{
		""dia"": 15,
		""valor"": 2659.7563
	},
	{
		""dia"": 16,
		""valor"": 48924.2448
	},
	{
		""dia"": 17,
		""valor"": 18419.2614
	},
	{
		""dia"": 18,
		""valor"": 0.0
	},
	{
		""dia"": 19,
		""valor"": 0.0
	},
	{
		""dia"": 20,
		""valor"": 35240.1826
	},
	{
		""dia"": 21,
		""valor"": 43829.1667
	},
	{
		""dia"": 22,
		""valor"": 18235.6852
	},
	{
		""dia"": 23,
		""valor"": 4355.0662
	},
	{
		""dia"": 24,
		""valor"": 13327.1025
	},
	{
		""dia"": 25,
		""valor"": 0.0
	},
	{
		""dia"": 26,
		""valor"": 0.0
	},
	{
		""dia"": 27,
		""valor"": 25681.8318
	},
	{
		""dia"": 28,
		""valor"": 1718.1221
	},
	{
		""dia"": 29,
		""valor"": 13220.495
	},
	{
		""dia"": 30,
		""valor"": 8414.61
	}
]}";
    public IList<FaturamentoDiario> Mensal;

    public void Deserializar()
    {
        var dados = Newtonsoft.Json.JsonConvert.DeserializeObject<FaturamentoMensal>(json);
        Mensal = dados?.Mensal ?? new List<FaturamentoDiario>();

        Console.WriteLine("Faturamento Mensal:");
        foreach (var item in Mensal)
        {
            Console.WriteLine($"Dia: {item.Dia}, Faturamento: {item.Valor}");
        }
    }

    public void MenorFaturamentoDoMes()
    {
        ValidacaoDeDados();
        var menorValor = Mensal.Where(m => m.Valor > 0).Min(m => m.Valor);
        var diaComMenorFaturamento = Mensal.First(d => d.Valor == menorValor);

        Console.WriteLine("Dia com menor faturamento: " + diaComMenorFaturamento.Dia);
        Console.WriteLine("Valor de menor faturamento: " + menorValor);
    }

    public void MaiorFaturamentoDoMes()
    {
        ValidacaoDeDados();

        var maiorValor = Mensal.Where(m => m.Valor > 0).Max(m => m.Valor);
        var diaComMaiorFaturamento = Mensal.First(m => m.Valor == maiorValor);
        Console.WriteLine("Dia com maior faturamento: " + diaComMaiorFaturamento.Dia);
        Console.WriteLine("Valor de maior faturamento: " + maiorValor);
    }


    public void QuantidadeDeDiasComFaturamentoMaiorQueAMedia()
    {
        ValidacaoDeDados();

        var diasComFaturamentoMaiorQueZero = Mensal.Where(m => m.Valor > 0).Count();
        var valorFaturantoTotal = Mensal.Sum(m => m.Valor);
        var media = valorFaturantoTotal / diasComFaturamentoMaiorQueZero;
        var diasComValorMaiorQueAMedia = Mensal.Count(m => m.Valor >= media);

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