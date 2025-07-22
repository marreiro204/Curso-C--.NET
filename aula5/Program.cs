// OPERADORES ARITMÉTICOS

namespace  aula5
{
    
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("CALCULADORA BEM SIMPLES");
            Console.WriteLine("digite um número:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite outro  número:");
            int number2 = Convert.ToInt32(Console.ReadLine());




          

            int sum = number + number2;
            int subtraction = number - number2;
            int multplication = number * number2;
            int division = number2 / number;
            int module = number2 % number;

            Console.WriteLine("o valor da Soma dos números é: " + sum);
            Console.WriteLine("o valor da Subtração dos números é: " + subtraction);
            Console.WriteLine("o valor da Multiplicação dos números é: " + multplication);
            Console.WriteLine("o valor da divisão dos números é: " + division);
            Console.WriteLine("o resto da divisão dos números é: " + module);     
        }
    }

}
