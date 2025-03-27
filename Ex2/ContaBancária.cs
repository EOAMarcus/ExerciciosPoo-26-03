using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class ContaBancaria
    {
        public string NConta;
        public string DonoConta;
        public double Saldo;

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Sem Saldo.");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo agora: {Saldo}");
        }
    }


}