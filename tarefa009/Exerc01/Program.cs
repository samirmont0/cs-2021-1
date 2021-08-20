using System;

namespace Exerc1
{
    class Program
    {
        public static int IdadeEmDias(string anosIdade, string mesesIdade, string diasIdade)
        {
            int totalDias = int.Parse(anosIdade) * 365 + int.Parse(mesesIdade) * 30 + int.Parse(diasIdade);
            return totalDias;
        }

        static void Main(string[] args)
        {
            string[] idade;
            Console.WriteLine("Digite sua idade: ");
            idade = Console.ReadLine().Split(" ");
            Console.WriteLine("O total de dias correspondente à sua idade é: " + IdadeEmDias(idade[0], idade[1], idade[2]) + "dias");
        }
    }
}
