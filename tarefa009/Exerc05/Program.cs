using System;

namespace Exerc5
{
    class Program
    {
        public static double qntdSalarioMinimo(double salarioMin, double salario)
        {
            double totalSalarioMin = salario / salarioMin;
            return totalSalarioMin;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o valor do salário minimo: ");
            double salarioMin = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do seu salário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("A quantidade de salarios mínimos desse salário é: " + qntdSalarioMinimo(salarioMin, salario).ToString("F"));
        }
    }
}
