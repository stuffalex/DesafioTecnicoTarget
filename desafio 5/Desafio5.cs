namespace DesafioTecnicoTarget.desafio_5;

public class Desafio5
{
    public IList<string> Palavra = new List<string>();

    public void InvertePalavra()
    {
        Console.WriteLine("Digite sua palavra: ");
        var palavra = Console.ReadLine();
        var palavraQuebrada = palavra.ToCharArray();
        char[] palavraInvertida = new char[palavraQuebrada.Length]; //inicializar com o tamanho do char array da palavra pra nao dar index out of range

        for (int i = 0; i < palavraQuebrada.Length; i++)
        {
            palavraInvertida[i] = palavraQuebrada[palavraQuebrada.Length - 1 - i];
        }

        string resultado = string.Concat(palavraInvertida);

        Console.WriteLine(resultado);
    }
}
