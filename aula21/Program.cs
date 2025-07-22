// MÉTODOS - PROGRAMAÇÃO ORIENTADA A OBJETOS - POO
namespace aula21;

public class Program
{
    public static void Main()
    {
        // CRIAR A INSTÂNCIA BANK
        Bank bankPraiano = new Bank();
        bankPraiano.Name = "Banco Praiano";
        bankPraiano.Id = 19;
        // MÉTODOS DA INSTÂNCIA DA CLASSE BANK
        bankPraiano.RequestCard();
    }
}
