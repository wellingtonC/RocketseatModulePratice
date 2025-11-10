using System.Globalization;

namespace PraticalExercices;
internal class DateTimer
{
    public void Date()
    {
        CultureInfo cultura = new CultureInfo("pt-BR");
        try
        {
            Console.Clear();
            Console.WriteLine("Escolha como quer ver a data atual");
            Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).\n2 - Apenas a data no formato\n" +
                "3 - Apenas a hora no formato de 24 horas.\n4 - A data com o mês por extenso.");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice > 0 && choice < 5)
            {
                DateTime today = DateTime.Now;
                string hour = DateTime.Now.ToString("HH:mm");
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(today.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura));
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(today.ToString("dddd, dd'/'MM'/'yyyy"));
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(hour);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(DateTime.Now.ToString("MMMM", new CultureInfo("pt-BR")));
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("opção invalida");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.Clear();
            Console.WriteLine("O valor de escolha deve ser entre 1 e 4 ");
        }
    }
}
