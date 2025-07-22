// GERENIADOR DE LISTA DE COMPRAS
namespace aula19;

using System.IO;

public class Program
{
    public static void Main()
    {
        string path = @"C:\Users\Samsung\Desktop\curso_dotnet\aula19\";
        string fileName = "Lista_de_compras.txt";
        string filePath = path + fileName;

        List<string> shoppingList = new List<string>();
        // lógica
        if (File.Exists(filePath))
        {
            shoppingList.AddRange(File.ReadAllLines(filePath));
        }

        while (true)
        {
            Console.WriteLine("\n=== Lista de Compras");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Exibir lista");
            Console.WriteLine("4. Exportar lista");
            Console.WriteLine("5. Limpar lista");

            Console.WriteLine("Escolha um item para continuar");

            string choiceUser = Console.ReadLine() ?? "";
            switch (choiceUser)
            {
                case "1":
                    Console.WriteLine("Digite o nome do item para adicionar: ");
                    string itemInsert = Console.ReadLine() ?? "";
                    if (!string.IsNullOrEmpty(itemInsert))
                    {
                        shoppingList.Add(itemInsert);
                        Console.WriteLine($"item '{itemInsert}' adicionado com sucesso'");
                    }
                    else
                    {
                        Console.WriteLine("o item não pode ser vazio");
                    }
                    break;

                case "2":
                    Console.WriteLine("digite o nome do item que quer remover");
                    string itemToRemove = Console.ReadLine() ?? "";
                    if (shoppingList.Remove(itemToRemove))
                    {
                        Console.WriteLine($"item '{itemToRemove}' removido com sucesso");
                    }
                    else
                    {
                        Console.WriteLine($"item '{itemToRemove}' não encontrado");
                    }
                    break;
                case "3":
                    Console.WriteLine("\n Itens na sua lista de compras");
                    if (shoppingList.Count == 0)
                    {
                        Console.WriteLine("sua lista está vazia");
                    }
                    else
                    {
                        for (int i = 0; i < shoppingList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {shoppingList[i]}");
                        }
                    }
                    break;

                case "4":
                    File.WriteAllLines(filePath, shoppingList);
                    Console.WriteLine("Lista salva com sucesso !! saindo..");
                    return;
                default:
                    Console.WriteLine("opção inválida. tente novamente");
                    break;

                case "5":
                    shoppingList.Clear();
                    Console.WriteLine("Lista de compras limpa com sucesso.");
                    break;





            }   
            

                

        }
    }
}
