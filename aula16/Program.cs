// ARRAYS
namespace aula16;

public class Program
{
    public static void Main()
    {
        // 1. declaração de array inicializando com valores
        string[] fruits = { "maçã", "banana", "caju", "manga" };

        //2 . acessar valores
        Console.WriteLine(fruits[1]);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        //3. contagem de indices
        Console.WriteLine("Quantidade de Índices: " + fruits.Length);

        //4. Alterar valores
        Console.WriteLine("valor antes da alteração: " + fruits[1]);
        fruits[1] = "abacaxi";
        Console.WriteLine("valor depois da alteração: " + fruits[1]);

        // declaração sem inicializar
        int[] numbers = new int[3];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}

