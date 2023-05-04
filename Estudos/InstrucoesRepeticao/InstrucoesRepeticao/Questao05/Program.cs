using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            int qtdeCaracter = (nome.Trim()).Length;
            for(int i = 1; i < qtdeCaracter; i++)
            {
                Console.Write("\n"+nome+"\n");
            }
        }
    }
}
