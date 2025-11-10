namespace PraticalExercices;
internal class EndMessage
{
    public bool FinishSucess() 
    {
        Console.WriteLine("Obrigado por Utilizar o sistema\nPressione qualquer tecla encerrar");
        Console.ReadKey();
        return false;
    }
}

