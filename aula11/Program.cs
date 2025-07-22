// SWITCH CASE

namespace aula11;

    public class Program
    {
    public static void Main()
    {
        // EXEMPLO 1:
        // int number = 1;
        // switch (number)
        // {
        //     case 1:
        //         Console.WriteLine("o número é 1");
        //         break;

        //     case 2:
        //         Console.WriteLine("o número é 2");
        //         break;
        // }

        // EXEMPLO 2:
        // Console.WriteLine("Dia da semana");
        // Console.WriteLine("Digite um número de 1 a 7:");
        // int dayOfWeek = Convert.ToInt32(Console.ReadLine());

        // switch (dayOfWeek)
        // {
        //     case 1:
        //         Console.WriteLine("Dia da semana é domingo");
        //         break;
        //     case 2:
        //         Console.WriteLine("Dia da semana é segunda-feira");
        //         break;
        //     case 3:
        //         Console.WriteLine("Dia da semana é terça-feira");
        //         break;
        //     case 4:
        //         Console.WriteLine("Dia da semana é quarta-feira");
        //         break;
        //     case 5:
        //         Console.WriteLine("Dia da semana é quinta-feira");
        //         break;
        //     case 6:
        //         Console.WriteLine("Dia da semana é sexta-feira");
        //         break;
        //     case 7:
        //         Console.WriteLine("Dia da semana é sábado");
        //         break;
        //     default:
        //         Console.WriteLine("dia inválido");
        //         break;
        // }

        // EXEMPLO 3:
        Console.WriteLine("Desempenho Escolar");
        Console.WriteLine("Digite sua nota:");
        int score = Convert.ToInt32(Console.ReadLine());

        switch (score)
        {
            case 10:
                Console.WriteLine("PARABÉNS NOTA MÁXIMA !");
                break;
            case 9:
                Console.WriteLine("PARABÉNS NOTA ALTA !");
                break;
            case 8:
                Console.WriteLine("PARABÉNS NOTA ALTA !");
                break;
            case 7:
                Console.WriteLine("NOTA BOA !");
                break;
            case 6:
                Console.WriteLine("NOTA MÉDIA !");
                break;
            case 5:
                Console.WriteLine("NOTA RUIM !");
                break;
            default:
                Console.WriteLine("NOTA HORRÍVEL !");
                break;
            
        }
        }

        

    }
