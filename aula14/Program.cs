// FOR LOOP
namespace aula14;

public class Program
{
    public static void Main()
    {
        // EXEMPLO 1:
        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        //EXEMPLO 2:
        Console.WriteLine("=====Tabela de Multiplicação");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,6}");
            }
            Console.WriteLine();
        }
    }
}