using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[101];

            for (int i = 0; i < 101; i++)
            {
                numeros[i] = i;
            }
            Console.Clear();
            Console.WriteLine("Numeros de 1 a 100\n");
            for (int j = 0; j < 101; j++)
            {
                Console.WriteLine(numeros[j]);
            }
        }
    }
}
