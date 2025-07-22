// MÉTODOS COM RETORNO - PROGRAMAÇÃO ORIENTADA A OBJETOS - POO
namespace aula22;

public class Program
{
    public static void Main()
    {
        // CRIAR INSTÂNCIA (OBJETO) DA CLASSE
        Person person = new Person();
        person.Name = "Matheus Vitoriano";

        // MÉTODOS
        Console.WriteLine("digite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        string response = person.IfLegalPersonRefactorName(age, person.Name);

        // if (iflegalperson == true)
        // {
        //     Console.WriteLine("liberado, pode entrar na balada");
        // }
        // else
        // {
        //     Console.WriteLine("opa, de menor não pode entrar na balada !!");
        // }

        Console.WriteLine(response);
    }
}
