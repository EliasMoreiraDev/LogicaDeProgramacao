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
            Console.WriteLine("\t\t---Triângulo---");

            Console.Write("Digite a medida o lado 1: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a medida o lado 2: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a medida o lado 3: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            if(lado1< (lado2+lado3) && lado2 < (lado3+lado1) && lado3 < (lado1 + lado2) && lado1 > (lado2 - lado3) && lado2 > (lado3 - lado1) && lado3 > (lado1 - lado2))
            {
                if (lado1 == lado2 && lado1 == lado3 && lado3 == lado2)
                {
                    Console.WriteLine("É um triângulo equilátro");
                }
                else if(lado1 == lado2 || lado1 == lado3 || lado3 == lado2)
                {
                    Console.WriteLine("É um triângulo isóscele");
                }
                else if(lado1 != lado2 && lado1 != lado3 && lado3 != lado2)
                {
                    Console.WriteLine("É um triângulo escaleno"); 
                }
            }
            else
            {
                Console.WriteLine("Essas medidas não são de um triângulo");
            }
            Console.ReadKey();
        }
    }
}
