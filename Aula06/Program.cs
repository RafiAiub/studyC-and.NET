namespace Aula06
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-----Verificador de números pares e ímpares-----");
            Console.WriteLine("Digite um número: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = number % 2;
            if (result == 0)
            {
                Console.WriteLine("O numero digitado é par!");
            }
            else
            {
                Console.WriteLine("O numero é impar!");
            }
        }
    }
}