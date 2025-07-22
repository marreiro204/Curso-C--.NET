// OPERADORES LÓGICOS
namespace aula9
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=====operadores lógicos=====");

            bool isLogged = true;
            bool hasAdminAcces = false;

            Console.WriteLine("\nInformações do usuário");
            Console.WriteLine("Usuário logado: " + isLogged);
            Console.WriteLine("acesso ao painel de administrador: " + hasAdminAcces);

            // operador (||) - OU

            if (isLogged || hasAdminAcces)
            {
                Console.WriteLine("Sistema concedido!!!");
            }
            else
            {
                Console.WriteLine("ACESSO NEGADO");
            }

            // operador (&&) - E
            if (isLogged && hasAdminAcces)
            {
                Console.WriteLine("Acesso ao painel de admnistrador concedido");

            }
            else
            {
                Console.WriteLine("Acesso ao painel de administrador negado");

            }
            // operador de negação (!) - NÃO
            if (!isLogged)
            {
                Console.WriteLine("usuário não está logado");
            }
            else
            {
                Console.WriteLine("usuário está logado");
             }
            


        }
    }
}
