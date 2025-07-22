namespace aula22;

public class Person
{
    // ATRIBUTOS
    public string Name;
    public int Age;

    // MÉTODOS
    public bool IfLegalPerson(int age)
    {
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // REFATORAR
    public string IfLegalPersonRefactor(int age)
    {
        string result = string.Empty;

        if (age >= 18)
        {
            result = "liberado, pode entrar na balada";
            return result;
        }
        else
        {
            result = "opa, de menor não pode entrar na balada !";
            return result;
        }
    }

    //Reafatorada de novo
    public string IfLegalPersonRefactorName(int age, string name)
    {
        string result = string.Empty;

        if (age >= 18)
        {
            result = "liberado," + name + "\npode entrar na balada";
            return result;
        }
        else
        {
            result = "opa, o(a)" + name + "\nde menor não pode entrar na balada !";
            return result;
        }
    }
    
}