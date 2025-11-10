namespace PraticalExercices;
internal class NameLastName
{
    public void NomeSobrenome()
    {
        Console.Clear();
        Console.WriteLine("Insira seu Primeiro nome");
        string nome = Console.ReadLine();
        Console.WriteLine("Insira seu Segundo nome");
        string sobrenome = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Bem vindo {0} {1}!!!", nome, sobrenome);
    }
}
