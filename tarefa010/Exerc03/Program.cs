using System;

namespace Exerc3
{
    class Program
    {
        //Função para reajustar saldo em 15%
        public static double saldoReajustado(double saldo)
        {
            double saldoComReajuste = saldo * 1.15; //Pega o saldo e adiciona 15%
            return saldoComReajuste; //Retorna o saldo com o reajuste
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o saldo: "); //Pede para o usuário digitar o reajuste
            double _saldo = double.Parse(Console.ReadLine()); //Lê o que o usuário digitou passando para o tipo double
            Console.WriteLine("O saldo reajustado em 15%, ficou " + saldoReajustado(_saldo) + " reais"); //Imprime o saldo com o reajuste
        }
    }
}
