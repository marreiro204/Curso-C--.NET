// OPERADORES RELACIONAIS
namespace aula8
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("======OPERADORES RELACIONAIS======");

            Console.WriteLine("DIGITE O VALOR DE X:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DIGITE O VALOR DE Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            string result;
            // operador de igualdade (==)
            if (x == y)
            {
                result = " x é igual a y";
            }
            else
            {
                result = " x é diferente de y";
            }
            Console.WriteLine("\nigualdade (==) " + result);

            // operador de diferença (!=)

            if (x != y)
            {
                result = " x é diferente de y";
            }
            else
            {
                result = " x é igual a y";

            }

            Console.WriteLine("\ndiferença (!=) " + result);

            // operador maior que (>)

            if (x > y)
            {
                result = "x é maior que y";
            }
            else
            {
                result = " x é menor que y";
            }

            Console.WriteLine("\noperador maior que (>): " + result);

            // operador menor que (<)

            if (x < y)
            {
                result = "x é menor que y";
            }
            else
            {
                result = " x é maior que y";
            }

            Console.WriteLine("\noperador menor que (<): " + result);

            // operador maior ou igual (>=)

            if (x >= y)
            {
                result = "x é maior ou igual a y";
            }
            else
            {
                result = " x é menor que y";
            }

            Console.WriteLine("\noperador maior ou igual (>=): " + result);
            
             // operador menor ou igual (<=)

            if (x <= y)
            {
                result = "x é menor ou igual a y";
            }
            else
            {
                result = " x é maior que y";
            }
            
            Console.WriteLine("\noperador menor ou igual (<=): " + result);
        }
    }
}
