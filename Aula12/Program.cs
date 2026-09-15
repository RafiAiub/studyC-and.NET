namespace Aula12;

public class Program
{
    public static void Main()
    {
        //Ex1
        //int i = 0;

        //while (i <= 5)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}

        //Ex2
        double budget = 100;
        while (budget > 0)
        {
            Console.WriteLine(budget);
            //Realizando alguma operação
            budget--;
        }
        Console.WriteLine("Saldo insuficiente");
    }
}