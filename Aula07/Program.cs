namespace Aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=====Operadores e Atribuição=====");

        //Inicializar a variavel
        int x = 10;
        Console.WriteLine("Valor inicial da variavel: " + x);

        //Operador de atribuição simples
        x = 20;
        Console.WriteLine("\nAtribuição Simples");
        Console.WriteLine("Valor de X: " + x);

        //Atribuição Composta (incremento) (++)
        x++; //Equivale a x = x + 1

        Console.WriteLine("\nAtribuição composta de Incremento (++)");
        Console.WriteLine("Novo valor de x: " + x);


        //Atribuição Composta (+=)
        x += 10; //Equivale a x = x + 10

        Console.WriteLine("\nAtribuição composta (+=)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (-=)
        x -= 10; //Equivale a x = x - 10

        Console.WriteLine("\nAtribuição composta (-=)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (*=)
        x *= 10; //Equivale a x = x * 10

        Console.WriteLine("\nAtribuição composta (*=)");
        Console.WriteLine("Novo valor de x: " + x);

        //Atribuição Composta (/=)
        x /= 10; //Equivale a x = x / 10

        Console.WriteLine("\nAtribuição composta (/=)");
        Console.WriteLine("Novo valor de x: " + x);
    }
}