namespace PraticalExercices.Functions;

internal class Count
{
    internal void caracteres() {
        string teste = "";
        Console.Clear();
        Console.WriteLine("Insira a palavra que deseja contar caracteres");
        string palavra = Console.ReadLine();
        Console.WriteLine("esta palvra contem {0} caracteres\nPressione qualquer tecla para sair", palavra.Length);
        Console.ReadKey();
    }
}
