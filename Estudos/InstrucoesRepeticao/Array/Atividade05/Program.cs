using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[5];
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write("\nDigite um valor de 10 a 50: ");
                int numero = int.Parse(Console.ReadLine());
                if(numero < 10 || numero > 50)
                {
                    Console.WriteLine("Informe um valor de 10 a 50\n");
                    i--;
                }
                else
                {
                    valores[i] = numero;
                }
            }
            for (int j = 0; j < valores.Length; j++)
            {
                Console.WriteLine(valores[j]);
            }
            
            
        }
    }
}
