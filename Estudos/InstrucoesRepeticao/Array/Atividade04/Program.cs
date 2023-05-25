using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] X  = new int[10];
            for (int i = 0; i < X.Length; i++)
            {
                Console.Write($"Digite o {i+1}º valor: ");
                X[i] = int.Parse(Console.ReadLine()) ;
            }

            Console.Write("Digite o indice do elemento que voce deseja ver: ");
            int p = int.Parse(Console.ReadLine());

            if(p<0 || p > 9)
            {
                Console.WriteLine("Informe um valor de 0 a 9");
            }
            else
            {
                Console.WriteLine($"O valor do indice {p} é "+ X[p-1]);
            }
            Console.ReadKey();
        }
    }
}
