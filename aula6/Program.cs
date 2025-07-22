// ESTRUTURA CONDICIONAL IF-ELSE

namespace aula6
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("VERIFICADOR DE NÚMEROS PARES OU ÍMPARES");

            Console.WriteLine("digite o número:");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = number % 2;

            if (result == 0)
            {
                Console.WriteLine("O número:  " + number + " que você digitou é par");

            }
            else
            {
                Console.WriteLine("O número:  " + number + " que você digitou é ímpar");
            }
        }
    }
}
