using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t--- Série de Fibonacci---");
            int num1 = 0;
            int num2 = 1;
            
           
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num2}\n");
                int soma = num1 + num2;
                
                num1 = num2;
                num2 = soma;
            }
                
                
            
        }
    }
}
