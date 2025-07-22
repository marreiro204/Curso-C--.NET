// CALCULADORA SIMPLES

namespace aula10
{
    public class Program
    {
        public static void Main()
        {
            bool varContinue = true;

            while (varContinue)
            {
                Console.WriteLine("===== Calculadora Simples =====");

                double num1, num2;
                Console.WriteLine("Digite o primeiro número:");
                while (!double.TryParse(Console.ReadLine(), out num1))
                    Console.WriteLine("Entrada inválida. Digite um número válido:");

                Console.WriteLine("Digite o segundo número:");
                while (!double.TryParse(Console.ReadLine(), out num2))
                    Console.WriteLine("Entrada inválida. Digite um número válido:");

                Console.WriteLine("Escolha uma operação:\n1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
                int operation;
                while (!int.TryParse(Console.ReadLine(), out operation) || operation < 1 || operation > 4)
                    Console.WriteLine("Operação inválida. Escolha entre 1 e 4.");

                double result = 0;
                bool operacaoValida = true;

                switch (operation)
                {
                    case 1: result = num1 + num2; break;
                    case 2: result = num1 - num2; break;
                    case 3: result = num1 * num2; break;
                    case 4:
                        if (num2 != 0) result = num1 / num2;
                        else { Console.WriteLine("Erro: divisão por zero."); operacaoValida = false; }
                        break;
                }

                if (operacaoValida)
                    Console.WriteLine($"Resultado: {result}");

                string response;
while (true)
{
    Console.WriteLine("Deseja realizar outra operação? (s/n)");
    response = Console.ReadLine().ToLower().Trim();

    if (response == "s" || response == "n")
    {
        break;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Digite apenas 's' para sim ou 'n' para não.");
    }
}

if (response == "n")
{
    varContinue = false;
}

            }


            Console.WriteLine("Programa encerrado.");
        }
    }
}

