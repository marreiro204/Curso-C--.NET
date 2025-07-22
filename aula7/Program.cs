// OPERADORES DE ATRIBUIÇÃO

namespace aula7
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("======== Operadores de Atribuição=========");

            // inicializar a vártiavel
            int x = 10;
            Console.WriteLine("Valor inicial da váriavel  x: " + x);

            // operador de atribuição simples (=)
            x = 20;
            Console.WriteLine("novo Valor  de x: " + x);

            // atribuição composta (incremento ++)

            x++; // equivale a x = x + 1
            Console.WriteLine("novo valor de x: " + x);

            // atribuição composta (+=)

            x += 10; // equivale a x = x + 10
            Console.WriteLine("novo valor de x: " + x);

            // atribuição composta (-=)

            x -= 10; // equivale a x = x - 10
            Console.WriteLine("novo valor de x: " + x);

            // atribuição composta (*=)

            x *= 10; // equivale a x = x * 10
            Console.WriteLine("novo valor de x: " + x);
            
              // atribuição composta (/=)

            x/=10; // equivale a x = x /  10
            Console.WriteLine("novo valor de x: " + x);





        }
    }
}
