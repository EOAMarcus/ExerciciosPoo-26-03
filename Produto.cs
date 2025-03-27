using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public void AdicionarEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverEstoque(int quantidade)
        {
            if (Quantidade >= quantidade)
            {
                Quantidade -= quantidade;
            }
            else
            {
                Console.WriteLine("Nao essa quantidade no estoque.");
            }
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Total estoque: {Quantidade}");
        }
    }


}