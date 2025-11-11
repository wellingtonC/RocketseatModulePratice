namespace PraticalExercices;
internal class Calculator
{
    public void StartOperations()
    {
        bool valid = false;
        while (!valid)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Insira o primeiro numero");
                double valor1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira o primeiro numero");
                double valor2 = Convert.ToDouble(Console.ReadLine());
                double soma = valor1 + valor2;
                double subtracao = valor1 - valor2;
                double divisao = valor1/valor2;
                double media = soma / 2;
                if (valor1 > 0)
                {
                    Console.Clear();
                    Console.WriteLine("A soma dos valores é igual a: {0}", soma);
                    Console.WriteLine("A subtração dos valores é igual a: {0}", subtracao);
                    Console.WriteLine("A divisão dos valores é igual a: {0}", divisao);
                    Console.WriteLine("A media dos valores é igual a: {0}", media);
                    Console.WriteLine("Pressione qualquer tecla para sair");
                    Console.ReadKey();
                    valid = true;
                }
                else
                {
                    Console.WriteLine("O primeiro valor deve ser maior que zero\nPressione qualquer tecla para tentar novamente");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Insira um valor valido");

            }
        }
    }
}
