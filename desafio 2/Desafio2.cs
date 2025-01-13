namespace DesafioTecnicoTarget;
public class Desafio2
{
    public void CalculaSeEhFibonacci(int numero)
    {
        Console.WriteLine($"{numero} está dentro do fibonacci?");

        var primeiro = 0;
        var segundo = 1;
        var proximoNumero = 0;
        var sequencia = new List<int> { primeiro, segundo };

        while (proximoNumero <= numero)
        {
            proximoNumero = CalculaFibonacci(primeiro, segundo);
            sequencia.Add(proximoNumero);

            primeiro = segundo;
            segundo = proximoNumero;

            if (proximoNumero == numero)
            {
                Console.WriteLine(string.Join(" -> ", sequencia));
                Console.WriteLine($"{numero} está dentro do fibonacci");

                return;
            }
        }
        Console.WriteLine(string.Join(" -> ", sequencia));
        Console.WriteLine($"{numero} não está dentro do fibonacci");
    }

    private int CalculaFibonacci(int primeiro, int segundo)
    {
        var proximoNumero = primeiro + segundo;
        return proximoNumero;
    }
}

