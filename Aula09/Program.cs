using System;

namespace Aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=====Operadores Lógicos=====");

        bool isLogged = true;
        bool hasAdminAcces = false;

        Console.WriteLine("\nInformações do Usuario:");
        Console.WriteLine("Usuario logado: " +  isLogged);
        Console.WriteLine("Acesso ao painel de adm: " + hasAdminAcces);

        //Operador (||) - OU
        if(isLogged || hasAdminAcces)
        {
            Console.WriteLine("Usuario logado");
        }
        else
        {
            Console.WriteLine("Usuario nao esta logado");
        }

        //Operador (&&) - E
        if (isLogged == true && hasAdminAcces == true)
        {
            Console.WriteLine("Acesso ao painel de adm concedido");
        }
        else
        {
            Console.WriteLine("Acesso ao painel adm negado");
        }

        //Operador (!) - Negação
        if (!isLogged)
        {
            Console.WriteLine("Usuario nao esta logado");
        }
        else
        {
            Console.WriteLine("Usuario esta logado");
        }
    }
}