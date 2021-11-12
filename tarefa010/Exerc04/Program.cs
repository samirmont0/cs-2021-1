using System;

namespace Exerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a % do IPI: "); 
            double ipi = double.Parse(Console.ReadLine());

            Peca peca1 = new Peca(); //Instância uma peça de roupa e atribui o código, valor e a quantidade de peças 

            Console.Write("\nDigite o código da peça 1: ");
            peca1.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da peça 1: ");
            peca1.Valor = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de peças 1: ");
            peca1.Quantidade = int.Parse(Console.ReadLine());

            Console.Clear();

            Peca peca2 = new Peca(); //Instância uma peça de roupa e atribui o código, valor e a quantidade de peças 

            Console.Write("Digite o código da peça 2: ");
            peca2.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da peça 2: ");
            peca2.Valor = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de peças 2: ");
            peca2.Quantidade = int.Parse(Console.ReadLine());

            Console.Clear();

            //Faz o calculo para ver o valor total das peças com o acréscimo do IPI
            double valorTotalPeca1 = peca1.Valor * peca1.Quantidade;
            double valorTotalPeca2 = peca2.Valor * peca2.Quantidade;
            double valorTotal = (valorTotalPeca1 + valorTotalPeca2) * (ipi / 100 + 1);

            Console.WriteLine("Valor total a ser pago: " + valorTotal + "reais"); //Imprime o valor total

        }
    }
}
