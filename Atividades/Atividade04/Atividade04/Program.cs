using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Aumento Salarial---\n");
            Console.WriteLine("Cargos: [1]- gerente [2]- Engenheiro [3]-Técnico");

            Console.Write("Informe seu cargo: ");
            int cargo = Convert.ToInt16(Console.ReadLine());

            Console.Write("Informe seu salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());


            double salarioReajustado;

            switch (cargo)
            {
                case 1:
                    salarioReajustado = salario + (salario * 0.1);
                    break;

                case 2:
                    salarioReajustado = salario + (salario * 0.2);
                    break;

                case 3:
                    salarioReajustado = salario + (salario * 0.3);
                    break;

                default:
                    salarioReajustado = salario + (salario * 0.4);
                    break;
            }
            
            Console.WriteLine($"Salário antigo: {salario.ToString("c")}\nSalário atual: {salarioReajustado.ToString("c")}");

            Console.ReadKey();

        }
    }
}
