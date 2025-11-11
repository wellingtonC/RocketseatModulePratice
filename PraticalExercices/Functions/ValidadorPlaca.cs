namespace PraticalExercices.Functions;
internal class ValidadorPlaca
{
    public bool ValidPlaca()
    {
        bool valid = false;
        while (!valid)
        {
            Console.Clear();
            Console.WriteLine("Insira a placa para validação");
            string placa = Console.ReadLine();
            if (placa!=null && placa.Count() < 7 && placa.Count() > 7)
            {
                Console.WriteLine(" A placa deve ter 7 caracteres");
                Console.Clear();
                Console.WriteLine("Pressione qualquer tecla para tentar novamente");
                Console.ReadKey();
            }
            else 
            {
                for (int x = 0; x < 2; x++) 
                {
                    if (!char.IsLetter(placa[x]))
                    {
                        Console.Clear();
                        Console.WriteLine("os tres primeiros caracteres precisam ser letras");
                        return false;
                    }
                }
                for (int y = 3; y < 6; y++) 
                {
                    if (!char.IsDigit(placa[y])) 
                    {
                        Console.Clear();
                        Console.WriteLine("os ultimos quatro caracteres precisam ser numeros");
                        return false;
                    }
                }
                valid = true;
            }
        }
        return valid;
    }
}
