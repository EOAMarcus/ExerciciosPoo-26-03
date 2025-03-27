using Exercicio_2;

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();

        Console.Write("Digite o numero da conta: ");
        conta.NConta = Console.ReadLine();
        Console.Write("Qual o  titular: ");
        conta.DonoConta = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("\nEscolha uma opcaoo:");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Sacar");
            Console.WriteLine("3. Exibir saldo");
            Console.WriteLine("4. Sair");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Qual o valor para deposito: ");
                double valor = Convert.ToDouble(Console.ReadLine());
                conta.Depositar(valor);
            }
            else if (opcao == 2)
            {
                Console.Write("Qual o valor para saque: ");
                double valor = Convert.ToDouble(Console.ReadLine());
                conta.Sacar(valor);
            }
            else if (opcao == 3)
            {
                conta.ExibirSaldo();
            }
            else if (opcao == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Opcao invalida.");
            }
        }
    }
}