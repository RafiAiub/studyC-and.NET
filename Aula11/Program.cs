namespace Aula11;

public class Program
{
    public static void Main()
    {
        //bool boolValue = true;

        //switch (boolValue)
        //{
        //    case true:
        //        Console.WriteLine("O número é true");
        //        break;
        //    case false:
        //        Console.WriteLine("O número é false");
        //        break;
        //}

        Console.WriteLine("=====Dia da semana=====");
        Console.WriteLine("Digite um numero de 1 a 7: ");
        int dayOffWeek = Convert.ToInt32(Console.ReadLine());

        switch (dayOffWeek)
        {
            case 1:
                Console.WriteLine("O dia da semana é domingo");
                break;
            case 2:
                Console.WriteLine("O dia da semana é segunda-feria");
                break;
            case 3:
                Console.WriteLine("O dia da semana é terça-feira");
                break;
            case 4:
                Console.WriteLine("O dia da semana é quarta-feira");
                break;
            case 5:
                Console.WriteLine("O dia da semana é quinta-feira");
                break;
            case 6:
                Console.WriteLine("O dia da semana é sexta-feira");
                break;
            case 7:
                Console.WriteLine("O dia da semana é sabado");
                break;

            default: Console.WriteLine("Dia invalido");
                break;
        }
    }
}