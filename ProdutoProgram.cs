using Exercicio_3;

class Program
{
    static void Main()
    {
        Produto produto = new Produto();

        Console.Write("Escreva o produto: ");
        produto.Nome = Console.ReadLine();
        Console.Write("Qual o preço do produto: ");
        produto.Preco = Convert.ToDouble(Console.ReadLine());
        Console.Write("Qual a quantidade em estoque: ");
        produto.Quantidade = int.Parse(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("\nEscolha uma opcao:");
            Console.WriteLine("1. Colocar no estoque");
            Console.WriteLine("2. Retirar do estoque");
            Console.WriteLine("3. Mostrar detalhes");
            Console.WriteLine("4. Sair");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Qual a quantidade para somar ao estoque: ");
                int quantidade = int.Parse(Console.ReadLine());
                produto.AdicionarEstoque(quantidade);
            }
            else if (opcao == 2)
            {
                Console.Write("Qual a quantidade para retirar do estoque: ");
                int quantidade = int.Parse(Console.ReadLine());
                produto.RemoverEstoque(quantidade);
            }
            else if (opcao == 3)
            {
                produto.ExibirDetalhes();
            }
            else if (opcao == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("invalido.");
            }
        }
    }
}