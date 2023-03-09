using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Digite o primeiro valor: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
            Console.ReadKey();
        }
    }
}
