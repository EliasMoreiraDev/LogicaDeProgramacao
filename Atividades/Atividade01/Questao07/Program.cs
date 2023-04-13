using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o total de prestações: ");
            int totalPrestacoes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o total de prestações pagas: ");
            int totalPagas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de cada prestação: R$");
            int valorPrestação = Convert.ToInt32(Console.ReadLine());

            int saldoPago = valorPrestação * totalPagas;
            Console.WriteLine($"Já foi pago R${saldoPago}");

            int saldoDevendo = (totalPrestacoes - totalPagas) * valorPrestação;
            Console.WriteLine($"Está devendo R${saldoDevendo}");
        }
    }
}
