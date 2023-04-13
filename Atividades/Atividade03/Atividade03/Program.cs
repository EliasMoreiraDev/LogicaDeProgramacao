using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Cálculo de IMC---");
            Console.Write("Digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite seu altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso/(altura*altura);
            String estado;

            if(imc < 18.5)
            {
                estado = "Magro";
            }
            else if(imc>18.5 && imc < 24.9)
            {
                estado = "Normal";
            }
            else if (imc > 25.0 && imc < 29.9)
            {
                estado = "Sobrepeso";
            }
            else if (imc > 30.0 && imc < 39.9)
            {
                estado = "Obesidade";
            }
            else
            {
                estado = "Obesidade Grave";
            }
            Console.WriteLine($"Seu IMC é {imc.ToString("n2")}\nVocê está {estado}");
            Console.ReadKey();
        }
    }
}
