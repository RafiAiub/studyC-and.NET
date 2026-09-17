namespace Aula17;

public class Program
{
    public static void Main()
    {
        string separator = "----------";

        //1. Declaração com inicialização de valores
        List<string> fruits = new List<string>()
        {
            "Manga",
            "Abacate",
            "Pera"
        };

        //2. Acessar os valores
        Console.WriteLine(fruits[2]);

        Console.WriteLine(separator);

        foreach (string fruit in fruits) 
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        // 3. Adicionar novos elementos
        fruits.Add("Uva");
        fruits.Add("Laranja");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //4. Remover elementos
        fruits.Remove("Uva");


        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //5. Contagem de elementos
        Console.WriteLine("Quantidade de frutas: " + fruits.Count);

        Console.WriteLine(separator);

        //6. Modificar um elemento
        fruits[2] = "Maracuja";

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //7. Limpar a lista
        fruits.Clear();

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //8. Declarar sem inicializar 
        List<int> numbers = new List<int>();

        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}