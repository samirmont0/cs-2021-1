using System;

namespace Exerc6
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Digite um inteiro: ");
            int inteiro = int.Parse(Console.ReadLine());
            Console.WriteLine("O antecessor de " + inteiro + " é " + (inteiro - 1) + " e o sucessor de " + inteiro + " é " + (inteiro + 1));
        }
    }
}
