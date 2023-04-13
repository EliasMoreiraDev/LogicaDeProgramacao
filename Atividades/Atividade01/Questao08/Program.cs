using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}\n{num1} - {num2} = {num1 - num2}\n{num1} * {num2} = {num1 * num2}\n{num1} / {num2} = {num1 / num2}\n");
        }
    }
}
