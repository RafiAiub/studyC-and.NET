namespace Aula05
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Calculadora simples");
            Console.WriteLine("Digite um numero");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            int sub = number2 - number1;
            int mult = number1 * number2;
            int div = number1 / number2;
            int module = number1 % number2;

            Console.WriteLine("O valor da soma é: " + sum);
            Console.WriteLine("O valor da subtração é: " +  sub);
            Console.WriteLine("O valor da muntiplicação é: " +  mult);
            Console.WriteLine("O valor da divisão é: " +  div);
            Console.WriteLine("O resto da divisão é: " +  module);
        }
    }
}