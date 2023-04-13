using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t--Digite as medidas em cm--");
            Console.Write("Largura da caixa: ");
            int largura = Convert.ToInt32(Console.ReadLine());

            Console.Write("Altura da caixa: ");
            int altura = Convert.ToInt32(Console.ReadLine());

            Console.Write("Profundidade da caixa: ");
            int profundidade = Convert.ToInt32(Console.ReadLine());

            int volume = largura * altura * profundidade;

            Console.WriteLine($"O volume da caixa é {volume}");
        }
    }
}
