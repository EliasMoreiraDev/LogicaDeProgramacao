using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hora = DateTime.Now.ToShortTimeString();
            Console.WriteLine("\nHora: " + hora);

            string data = DateTime.Now.ToShortDateString();
            Console.WriteLine("Data: " + data);

        }
    }
}
