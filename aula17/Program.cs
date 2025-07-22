// LISTAS

namespace aula17;

public class Program
{
    public static void Main()
    {
        string separator = "===============================";
        // 1. Declaração com inicialização de valores
        List<string> fruits = new List<string>()
        {
            "manga",
            "abacate",
            "pera"
        };

        // 2. acessar valores

        Console.WriteLine(fruits[2]);

        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // 3. adicionar elementos na lista
        fruits.Add("limão");
        fruits.Add("laranja");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine(separator);

        // 4. Remover elementos
        fruits.Remove("limão");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        //5. contagem de elementos
        Console.WriteLine("quantidade de elementos: " + fruits.Count);

        Console.WriteLine(separator);

        //6 modificar elementos
        fruits[2] = "Maracujá";

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine(separator);
        //7. limpar lista
        fruits.Clear();

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //8. Declaração sem inicialização
        List<int> numbers = new List<int>();

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    } 
}