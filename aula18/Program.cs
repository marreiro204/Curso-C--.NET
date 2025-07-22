// TRABALHANDO COM ARQUIVOS
namespace aula18;

using System.IO;

public class Program
{
    public static void Main()
    {
        // 1. criar arquivo
        File.WriteAllText("file.txt", "Hello World");
        Console.WriteLine("Arquivo criado com sucesso");

        // 2. criar arquivo em local específico
        string path = @"C:\Users\Samsung\Desktop\curso_dotnet\aula18\fileName.txt";

        string content = "hello world";

        File.WriteAllText(path, content);
        Console.WriteLine("Arquivo criado com sucesso");

        // 3. criar um arquivo Word
        // string path2 = @"C:\Users\Samsung\Desktop\curso_dotnet\aula18";
        // string fileName = "myDocument.Doc";
        // string filhePath = path2 + fileName;

        // string content2 = "hello world";

        // File.WriteAllText(filhePath, content2);
        // Console.WriteLine("Arquivo  Word criado com sucesso");

        // 4. modificar um arquivo inserindo parágrafo
        string path2 = @"C:\Users\Samsung\Desktop\curso_dotnet\aula18";
        string fileName = "myDocument.Doc";
        string filePath = path2 + fileName;

        string additionalContent = "CURSO DE C# e DOT.NET";

        File.AppendAllText(filePath, additionalContent);
        Console.WriteLine("Arquivo  Word atualizado  com sucesso");

        //5.  ler o arquivo
        string fileContent = File.ReadAllText(filePath);

        Console.WriteLine( fileContent);
        

    }
}
