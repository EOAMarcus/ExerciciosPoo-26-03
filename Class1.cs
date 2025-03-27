using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aluno
{
    public string RA;
    public string NOME;
    public double NOTAPROVA;
    public double NOTATRABALHO;
    public double NOTAFINAL;

    public void DADOSDEALUNOS()
    {

        Console.WriteLine("Digite o RA do aluno");
        RA = Console.ReadLine();
        Console.WriteLine("Digite o nome do aluno");
        NOME = Console.ReadLine();
        Console.WriteLine("Digite o valor da nota da prova");
        NOTAPROVA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da nota do trabalho");
        NOTATRABALHO = Convert.ToDouble(Console.ReadLine());

    }
    public void MEDIADOSALUNOS()
    {
        NOTAFINAL = (NOTAPROVA+ NOTATRABALHO) / 2;
    }
    public void NOTAFINALL()
    {
        if (NOTAFINAL >= 6.0)
        {
            Console.WriteLine($" {NOME} {RA} aprovado, média {NOTAFINAL:F2}.");
        }
        else
        {
            double notamedia = 12;
            notamedia = 12 - NOTAFINAL;
            Console.WriteLine($"aluno {NOME} (ra: {RA}) precisa de {notamedia:F2} na prova final.");
        }
    }
}