// PROGRAMAÇÃO ORIENTADA A OBJETOS - POO

namespace aula20;

public class Program
{
    public static void Main()
    {
        // INSTÂNCIA (OBJETO) DA CLASSE Cake.
        var cakeStrawberry = new Cake();

        // SETAR AS INFORMAÇÕES DO BOLO
        cakeStrawberry.Id = 1;
        cakeStrawberry.Name = "Bolo Strawberry";
        cakeStrawberry.Description = "Bolo de morango recheado";
        cakeStrawberry.Value = 30;
        cakeStrawberry.IsFilling = true;

        // MOSTRAR AO USÚARIO
        Console.WriteLine("Id: " + cakeStrawberry.Id);
        Console.WriteLine("Nome: " + cakeStrawberry.Name);
        Console.WriteLine("Descrição: " + cakeStrawberry.Description);
        Console.WriteLine("Valor: R$" + cakeStrawberry.Value);
        Console.WriteLine("Tem recheio: " + cakeStrawberry.IsFilling);

        Console.WriteLine("===================================");

        // INSTÂNCIA DE BOLO DE CHOCOLATE
        var cakeChocolate = new Cake();
        cakeChocolate.Id = 2;
        cakeChocolate.Name = "Bolo Chocolate";
        cakeChocolate.Description = "Bolo de chocolate";
        cakeChocolate.Value = 20;
        cakeChocolate.IsFilling = false;

        Console.WriteLine("===================================");

        // LISTA DOS BOLOS
        Console.WriteLine("LISTA DE BOLOS:");
        List<Cake> cakeList = new List<Cake>();
        cakeList.Add(cakeStrawberry);
        cakeList.Add(cakeChocolate);

        // VISUALIZAR A LISTA
        foreach (Cake cake in cakeList)
        {
            Console.WriteLine("Id: " + cake.Id);
            Console.WriteLine("Nome: " + cake.Name);
            Console.WriteLine("Descrição: " + cake.Description);
            Console.WriteLine("Valor: R$" + cake.Value);
            Console.WriteLine("Tem recheio: " + cake.IsFilling);
        }

    }
}