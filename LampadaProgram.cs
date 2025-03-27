using Exercicio_4;

class Program
{
    static void Main()
    {
        Lampada lampada = new Lampada();

        while (true)
        {
            Console.WriteLine("\nEscolha o número correspondente a opção:");
            Console.WriteLine("1. ON");
            Console.WriteLine("2. OFF");
            Console.WriteLine("3. DESCRIÇAO DA LÂMPADA");
            Console.WriteLine("4. EXIT");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                lampada.Ligar();
            }
            else if (opcao == 2)
            {
                lampada.Desligar();
            }
            else if (opcao == 3)
            {
                lampada.MostrarEstado();
            }
            else if (opcao == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Opcaoo invalida.");
            }
        }
    }
}