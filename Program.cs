// See https://aka.ms/new-console-template for more information
using DesafioTecnicoTarget;
using DesafioTecnicoTarget.desafio_4;
using DesafioTecnicoTarget.desafio_5;
using DesafioTecnicoTarget.desafio3;

//desafio 1 
var soma = new Desafio1();
Console.WriteLine("DESAFIO 1");
Console.WriteLine("o valor de soma é: ", soma.Imprimir(0));
Console.WriteLine("");
////desafio 2
var fibonacci = new Desafio2();
Console.WriteLine("DESAFIO 2");
fibonacci.CalculaSeEhFibonacci(54);
Console.WriteLine("");

//desafio 3
var dados = new Desafio3();
Console.WriteLine("DESAFIO 3");

dados.Deserializar();

dados.MenorFaturamentoDoMes();
dados.MaiorFaturamentoDoMes();
dados.QuantidadeDeDiasComFaturamentoMaiorQueAMedia();
Console.WriteLine("");


//desafio 4

var valor = new Desafio4();
Console.WriteLine("DESAFIO 4");

valor.MontaFaturamentos();
valor.CalculaPercentualPorEstado();
Console.WriteLine("");

//Desafio5
Console.WriteLine("DESAFIO 5");
Console.WriteLine("DEVE ESCREVER PALAVRA NO TECLADO");
var palavra = new Desafio5();
palavra.InvertePalavra();