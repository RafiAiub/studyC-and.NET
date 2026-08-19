namespace Aula08
{
    public class Program()
    {
        public static void Main()
        {
            Console.WriteLine("=====Operadores Relacionais=====");
            Console.WriteLine("Digite o primeiro número: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int y = Convert.ToInt32(Console.ReadLine());

            string result;

            //Operador de igualdade (==)
            if (x == y) 
            {
                result = "x é igual a y";
            }else
            {
                result = "x é diferente de y";
            }
            Console.WriteLine("\nIgualdade (==): " + result);

            //Operador de diferença (!=)
            if (x != y) 
            {
                result = "x é ferente de y";
            }
            else
            {
                result = "x é igual a y";
            }
            Console.WriteLine("\nDiferente (!=): " + result);

            //Operador maior que (>)
            if(x > y)
            {
                result = "x é maior que y";
            }else
            {
                result = "x é não é maior que y";
            }
            Console.WriteLine("\nMaior que (>): " + result);

            //Operador menor que (<)
            if (x < y)
            {
                result = "x é menor que y";
            }
            else
            {
                result = "x é não é menor que y";
            }
            Console.WriteLine("\nMenor que (<): " + result);

            //Operador maior ou igual que (>=)
            if (x >= y)
            {
                result = "x é maior ou igual a y";
            }
            else
            {
                result = "x é não é maior ou igual a y";
            }
            Console.WriteLine("\nMaior ou igual a (>=): " + result);

            //Operador menor ou igual que (<=)
            if (x <= y)
            {
                result = "x é menor ou igual a y";
            }
            else
            {
                result = "x é não é menor ou igual a y";
            }
            Console.WriteLine("\nMenor ou igual que (<=): " + result);
        }
    }
}