using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBreak
{
    internal class Program
    {
        static void Main(string[] args)

        { 
            Console.WriteLine("\t\t---Grãos e Xadrez---");
            decimal graos = 1;
            
            int casaXadrez = 1;

            for (; casaXadrez <= 64; casaXadrez++)
            {
                decimal kilos = graos / 15432;
                Console.WriteLine($"Quantidade de graos: {graos:n2}");
                graos += graos;

                
                Console.WriteLine($"Quantidade de kilos {kilos:n2}\n");
            }


        }
    }
}
