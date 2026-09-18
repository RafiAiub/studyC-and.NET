namespace Lista_De_Compras_Com_Orçamento;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite seu orçamento:");
        double orcamento = Convert.ToDouble(Console.ReadLine());

        List<string> produtos = new List<string>();
        List<double> precos = new List<double>();

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string produto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            if (preco <= orcamento)
            {
                produtos.Add(produto);
                precos.Add(preco);

                Console.WriteLine("-----PRODUTO ADICIONADO!-----");

                orcamento = orcamento - preco;

                Console.WriteLine("Orçamento restante: R$" + orcamento);

                Console.WriteLine("Deseja adicionar outro produto? (s/n)");
                string resposta = Console.ReadLine();

                if (resposta == "n")
                {
                    continuar = false;
                }
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
                Console.WriteLine("----------");
                Console.WriteLine("Orçamento restante: R$" + orcamento);

                continuar = false;
            }
        }

        Console.WriteLine("===== RESUMO DA COMPRA =====");

        for (int i = 0; i < produtos.Count; i++)
        {
            Console.WriteLine(produtos[i] + " - R$" + precos[i]);
        }

        Console.WriteLine("Orçamento restante: R$" + orcamento);
        Console.WriteLine("Quantidade de produtos: " + produtos.Count);
    }
}