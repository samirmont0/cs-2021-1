using System;

namespace Exerc3
{
    class Program
    {
        public static double saldoReajustado(double saldo)
        {
            double saldoComReajuste = saldo * 1.15;
            return saldoComReajuste;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o saldo: ");
            double _saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("O saldo reajustado em 15%, ficou " + saldoReajustado(_saldo) + " reais");
        }
    }
}
