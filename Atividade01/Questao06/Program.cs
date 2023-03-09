using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anos = 365, meses = 30, semanas = 7;
            Console.Write("Digite o quantos dias: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{dias} são igual a {dias / anos} ano ou {dias / meses} meses ou {dias / semanas} semanas");
        }
    }
}
