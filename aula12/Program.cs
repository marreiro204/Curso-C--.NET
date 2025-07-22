// ESTRUTURA DE REPETIÇÃO WHILE
namespace aula12;

public class Program
{
    public static void Main()
    {
        // EXEMPLO 1:
        // int i = 0;

        // while (i <= 5)
        // {
        //     Console.WriteLine("LOOP");
        //     i++;
        // }

        // EXEMPLO 2:
        double budget = 100;

        while (budget > 0)
        {
            Console.WriteLine(budget);
            // Realizando alguma operação
            budget--;
        }
        Console.WriteLine("SALDO INSUFICIENTE !");
    }
}

