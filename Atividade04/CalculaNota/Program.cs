using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Calcula nota do aluno---");

            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Nota do 1º Bimestre: ");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nota do 2º Bimestre: ");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nota do 3º Bimestre: ");
            int nota3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nota do 4º Bimestre: ");
            int nota4 = Convert.ToInt32(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4)/ 4;
            char conceito = ' ';
            string situacao;

            if (media >= 90)
            {
                conceito = 'A';
                
            }
            else if (media >= 80)
            {
                conceito = 'B';
                
            }
            else if (media >= 60)
            {
                conceito = 'C';
               
            }
            else if (media >= 40)
            {
                conceito = 'D';
                    
            }
            else if (media >= 20)
            {
                conceito = 'E';
                
            }


            switch (conceito)
            {
                case 'A':
                    situacao = "Aprovado";
                    break;
                case 'B':
                    situacao = "Aprovado";
                    break;
                case 'C': 
                    situacao = "Aprovado";
                    break;

                case 'D':
                    situacao = "Recuperação";
                    break;

                case 'E':
                    situacao = "Exame";
                    break;
                    
                default:
                    situacao = "Reprovado";
                    break;
                
            }
            Console.WriteLine($"Olá {nome}, você ganhou {conceito} e está {situacao}");
            




        }
    }
}
