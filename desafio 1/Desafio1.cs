namespace DesafioTecnicoTarget
{
    public class Desafio1
    {
        public int INDICE = 13;
        public int SOMA = 0;
        public int K = 0;
        //1) Observe o trecho de código abaixo: int INDICE = 13, SOMA = 0, K = 0;
        //Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
        //Imprimir(SOMA);
        //Ao final do processamento, qual será o valor da variável SOMA?

        public int Imprimir(int soma)
        {
            while(K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            return SOMA;
        }
    }
}
