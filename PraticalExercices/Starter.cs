using PraticalExercices.Functions;

namespace PraticalExercices;

internal class Starter
{
    public void starter()
    {
        NameLastName nameLastName = new NameLastName();
        Name name = new Name();
        EndMessage endMessage = new EndMessage();
        Calculator calculator = new Calculator();
        Count count = new Count();
        ValidadorPlaca validadorPlaca = new ValidadorPlaca();
        DateTimer dateTimer = new DateTimer();

        Console.WriteLine("Bem vindo ao projeto de teste Rocketseat\nPressione qualquer tecla para inciar....");
        Console.ReadKey();

        bool control = true;
        while (control)
        {
            Console.Clear();
            Console.WriteLine("Escolha o projeto que será executado\n1 - Mensagem de boas vindas\n2 - Nome e Sobrenome\n3 - Calculadora\n4 - Contador de caracteres\n" +
                "5 - Validador de placas\n6 - Calendario");
            var resultado = Console.ReadLine();
            try
            {
                int valor = Convert.ToInt32(resultado);
                switch (valor)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Favor inserir um valor maior que zero\nPressione qualquer tecla para tentar novamente....");
                        Console.ReadKey();
                        break;
                    case 1:
                        name.readName();
                        control = endMessage.FinishSucess();
                        break;
                    case 2:
                        nameLastName.NomeSobrenome();
                        control = endMessage.FinishSucess();
                        break;
                    case 3:
                        calculator.StartOperations();
                        control = endMessage.FinishSucess();
                        break;
                    case 4:
                        count.caracteres();
                        control = endMessage.FinishSucess();
                        break;
                    case 5:
                        bool validator = validadorPlaca.ValidPlaca();
                        Console.WriteLine(validator);
                        control = endMessage.FinishSucess();
                        break;
                    case 6:
                        dateTimer.Date();
                        control = endMessage.FinishSucess();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Favor inserir um valor entre 1 - 6\nPressione qualquer tecla para tentar novamente....");
                        Console.ReadKey();
                        break;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Por favor insira um numero valido\nPressione qualquer tecla para tentar novamente....");
                Console.ReadKey();
            }
        }
    }
}
