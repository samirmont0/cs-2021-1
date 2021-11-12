using System;

namespace Exerc5
{
    class Program
    {
        //Função para calcular a quantidade de salários mínimos que têm um determinado salário
        public static double qntdSalarioMinimo(double salarioMin, double salario)
        {
            double totalSalarioMin = salario / salarioMin; //Divide o valor de salário pelo valor do salário mínimo
            return totalSalarioMin; //Retorna a qntd. total de salários mínimos que esse salário tem
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o valor do salário minimo: "); //Solicita ao usuário o valor do salário mínimo
            double salarioMin = double.Parse(Console.ReadLine()); //Lê o valor do salário mínimo e passa esse valor para double
            Console.Write("Digite o valor do seu salário: "); //Solicita ao usuário o valor do salário 
            double salario = double.Parse(Console.ReadLine()); //Lê o valor do salário e passa esse valor para double
            Console.WriteLine("A quantidade de salarios mínimos desse salário é: " + qntdSalarioMinimo(salarioMin, salario).ToString("F")); //Chama a função e faz um ToString("F") com o valor retornado para deixar com duas casas decimais
        }
    }
}
