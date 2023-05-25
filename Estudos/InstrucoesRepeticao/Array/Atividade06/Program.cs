using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] X = new int[10];
            int[] Y = new int[10];

            for (int i = 0; i < X.Length; i++)
            {
                Console.Write("Digite o valor: ");
                X[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(X);
            for (int j = 0; j < X.Length; j++)
            {
                Y[j] = X[j];
            }
            Console.WriteLine("\nSequencia de numeros revertida\n");
            for (int k = 0; k < X.Length; k++)
            {
                Console.Write(Y[k] + "  ");
            }
            Console.ReadKey();

        }
    }
}
