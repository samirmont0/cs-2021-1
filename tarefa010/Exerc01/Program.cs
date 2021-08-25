using System;

namespace Exerc1
{
    class Program
    {
        //Função para transformar a idade passada em dias
        public static int IdadeEmDias(string anosIdade, string mesesIdade, string diasIdade)
        {
            /* A variável totalDias recebe a quantidade de anos * 365 (~ num° total de dias em um ano)
               + qntd de meses da pessoa * 30 (~ num° total de dias em um mês) + qntd de dias da idade da pessoa (sem considerar ano e mês) */
            int totalDias = int.Parse(anosIdade) * 365 + int.Parse(mesesIdade) * 30 + int.Parse(diasIdade);
            return totalDias;
        }

        static void Main(string[] args)
        {
            string[] idade; // Declaração de array de string idade.
            Console.WriteLine("Digite sua idade: "); //Pedido de idade para o usuário que deve ser fornecido dessa maneira (Ex.: 22 5 25)
            idade = Console.ReadLine().Split(" "); //A função split divide pelo espaço a string.
            Console.WriteLine("O total de dias correspondente à sua idade é: " + IdadeEmDias(idade[0], idade[1], idade[2]) + "dias"); // Chama a função IdadeEmDias
        }
    }
}
