// INPUT AND OUTPUT

namespace aula4;

public class Program
{
    public static void Main()
    {
        // solicita o nome do usuário
        Console.WriteLine("---------LOGIN---------");
        Console.WriteLine("digite seu nome:");
        string name = Console.ReadLine();
        Console.WriteLine("BEM VINDO:" + name);
        // solicita a idade do usuário
        Console.WriteLine("digite sua idade:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("------------------------");
        Console.WriteLine("bem vindo:"+ name + "vi que já tem" + age + "anos");


    }
}