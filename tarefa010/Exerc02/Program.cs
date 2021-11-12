using System;

namespace Exerc2
{
    class Program
    {
        //Função que calcula a média de 3 números
        public static int calculaMedia(int numA, int numB, int numC)
        {
            int media = (numA + numB + numC) / 3; //Soma as três variáveis e divide por 3
            return media; //Retorna a média calculada
        }

        static void Main(string[] args)
        {
            Console.WriteLine("A média de 8, 9 e 7 é: " + calculaMedia(8, 9, 7)); //Chama a função de calcular a média
            Console.WriteLine("A média de 4, 5 e 6 é: " + calculaMedia(4, 5, 6)); //Chama a função de calcular a média
            Console.WriteLine("A soma dessas duas médias é: " + (calculaMedia(4, 5, 6) + calculaMedia(8, 9, 7))); //Chama a função de calcular a média duas vezes e soma essas médias
            Console.WriteLine("A média dessas duas médias é: " + (double)(calculaMedia(4, 5, 6) + calculaMedia(8, 9, 7)) / 2); //Chama a função de calcular a média duas vezes, soma essas médias e faz a média delas.
        }
    }
}
