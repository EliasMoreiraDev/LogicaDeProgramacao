using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelhorSerie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nvcand1=0,
                nvcand2 = 0,
                nvcand3 = 0,
                nvbrancos = 0,
                nvnulos = 0,
                neleitores = 0,
                op;
            string resposta = "SIM";

            do
            {
                Console.WriteLine("Data: "+DateTime.Now.ToString("dd-MM-yyyy"));

                Console.WriteLine("\n\t--- Qual é a melhor série de todos os tempos---");
                Console.WriteLine("[1] The Big Bang Theory\n\t[2]Game of Thrones\n\t[3]The Glory\n\t[4]Outra\n\tNão sei");
                Console.WriteLine("\nInforme sua opção");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        nvcand1++;
                        break;
                    case 2:
                        nvcand2++;
                        break;
                    case 3:
                        nvcand3++;
                        break;
                    case 4:
                        nvbrancos++;
                        break;
                    case 5:
                        nvnulos++;
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;

                }
                Console.WriteLine("\nVoto realizado com sucesso");
                Console.WriteLine("\nDeseja realizar outro voto?");
                Console.WriteLine("Digite [S] ou [SIM] para prosseguir:");
                resposta = Console.ReadLine().ToUpper();

            } while (resposta == "SIM" || resposta == "S");

            neleitores = nvcand1+nvcand2+nvcand3+nvbrancos+nvnulos;
            Console.WriteLine("Número de votos: "+neleitores);
            Console.WriteLine($"The Big Bang Theory: {nvcand1}" +
                $"\n\tGame of Thrones: {nvcand2}" +
                $"\n\tThe Glory: {nvcand3}" +
                $"\n\tOutra: {nvbrancos}" +
                $"\n\tNão sei: {nvnulos}");
        }
    }
}
