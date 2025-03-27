using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Lampada
    {
        public bool Ligada;

        public void Ligar()
        {
            Ligada = true;
        }

        public void Desligar()
        {
            Ligada = false;
        }

        public void MostrarEstado()
        {
            if (Ligada)
            {
                Console.WriteLine("ON.");
            }
            else
            {
                Console.WriteLine("OFF.");
            }
        }
    }

}