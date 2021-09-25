using System;

namespace Divisao
{
    class Divisao
    {
        public static string divide(int dividendo, int divisor)
        {
            if(divisor == 0)
            {
                throw new ArithmeticException("Divisão por 0");
            }
            else
            {
                return "O resultado da divisão foi: " + (dividendo / divisor);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do dividendo: ");
            int dividendo = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(divide(dividendo, divisor));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
