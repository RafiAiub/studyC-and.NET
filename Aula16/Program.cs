namespace Aula16;

public class Program
{
    public static void Main()
    {
        string separator = "----------";

        //1. Declaração de Array iniciando com valores
        string[] fruits = { "Maçã", "Banana", "Caju", "Manga" };

        //2. Acessar os valores
        Console.WriteLine(fruits[1]);

        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //3. Contagem de indices 
        Console.WriteLine("Quantidade de indices: " + fruits.Length);

        Console.WriteLine(separator);

        //4. Alterar os valores
        Console.WriteLine("Valor antes da alteração: " + fruits[1]);
        fruits[1] = "Abacaxi";
        Console.WriteLine("Valor depois da alteração: " + fruits[1]);

        Console.WriteLine(separator);

        //5.Declaração de Array sem iniciar com valores
        int[] numbers = new int[3];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}