using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do funcionário: ");
            String nomeFuncionario = Console.ReadLine();

            Console.Write("Salário fixo: ");
            int salarioFixo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Total de vendas: R$");
            int totalVendas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Porcentual ganho sobre o valor de vendas: ");
            int porgentualGanho = Convert.ToInt32(Console.ReadLine());

            int salarioTotal = salarioFixo + (totalVendas * (porgentualGanho / 100));


            Console.WriteLine($"Olá {nomeFuncionario}, você recebe {salarioTotal}");
        }
    }
}
