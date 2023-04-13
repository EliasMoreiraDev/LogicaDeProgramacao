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
            Console.WriteLine("\t\t--- Calcula Média da turma ---\n");
            Console.Write("Quantos alunos tem na turma: ");
            int qtdeAlunos = int.Parse(Console.ReadLine());
            int cont = 1;
            int bimestre = 1;
            int mediaAluno;
            int mediaTurma = 0;
            int nota=0;
            while (cont <= qtdeAlunos) 
            {
                
                while (bimestre <= 4) 
                {
                    
                    Console.Write($"Digite a nota do {cont}º aluno do {bimestre}º bimestre: ");
                    nota += int.Parse(Console.ReadLine());
                    bimestre++;
                    
                }
                if(bimestre > 4)
                {
                    mediaAluno = nota / 4;
                    
                    Console.WriteLine($"Média do {cont}º aluno: {mediaAluno}");
                    
                    Console.WriteLine("--------------------------------------------");
                    bimestre = 1;

                    mediaTurma += mediaAluno;
                    mediaAluno = 0;
                    nota = 0;
                }
                
                cont++;
                


            }
            Console.WriteLine($"Média turma: {mediaTurma/qtdeAlunos}");
        }
    }
}
