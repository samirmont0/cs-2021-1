using System;

namespace Exerc6
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Digite um inteiro: "); //Pede para o usuário digitar um inteiro
            int inteiro = int.Parse(Console.ReadLine()); //Lê o que o usuário digitou e passa o que foi escrito para o tipo int
            Console.WriteLine("O antecessor de " + inteiro + " é " + (inteiro - 1) + " e o sucessor de " + inteiro + " é " + (inteiro + 1)); //Escreve o antecessor e o sucessor do inteiro digitado pelo usuário
        }
    }
}
