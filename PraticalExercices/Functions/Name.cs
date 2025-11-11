namespace PraticalExercices.Functions;

internal class Name
{
    public void readName()
    {
        Console.Clear();
        Console.WriteLine("Insira seu Primeiro nome");
        string nome = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Olá, {1}! Seja muito bem-vindo!", nome);
    }
}

