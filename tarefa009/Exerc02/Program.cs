using System;

namespace Exerc2
{
    class Program
    {
        public static int calculaMedia(int numA, int numB, int numC)
        {
            int total = (numA + numB + numC) / 3;
            return total;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("A média de 8, 9 e 7 é: " + calculaMedia(8, 9, 7));
            Console.WriteLine("A média de 4, 5 e 6 é: " + calculaMedia(4, 5, 6));
            Console.WriteLine("A soma dessas duas médias é: " + (calculaMedia(4, 5, 6) + calculaMedia(8, 9, 7)));
            Console.WriteLine("A média dessas duas médias é: " + (double)(calculaMedia(4, 5, 6) + calculaMedia(8, 9, 7)) / 2);
        }
    }
}
