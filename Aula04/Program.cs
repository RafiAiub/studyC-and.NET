namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("-----CADASTRO DE USUARIO-----");

        //Solicitar o nome do usuario:
        Console.WriteLine("Qual seu nome? ");
        string name = Console.ReadLine();

        //Solicitar idade do usuario:
        Console.WriteLine("Digite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("----------");

        Console.WriteLine("Nome do usuario: " + name);
        Console.WriteLine("Idade do usuario: " + age);
    }
}