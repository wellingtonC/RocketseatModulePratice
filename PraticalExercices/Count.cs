namespace PraticalExercices;

internal class Count
{
    internal void caracteres() {
        Console.Clear();
        Console.WriteLine("Insira a palavra que deseja contar caracteres");
        string palavra = Console.ReadLine();
        Console.WriteLine("esta palvra contem {0} caracteres\nPressione qualquer tecla para sair", palavra.Count());
        Console.ReadKey();
    }
}
