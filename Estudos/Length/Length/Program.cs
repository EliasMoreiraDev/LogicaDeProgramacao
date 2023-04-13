using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "O comunismo falhou, falha e falhará";

            int tamanho = a.Length;
            Console.WriteLine(tamanho);

            a = a.Replace(" ", "");
            Console.WriteLine(a);
            a = "Pai rico pai pobre";

            char b = a[4];
            Console.WriteLine(b);

            bool resultado = a.Contains("rico");
            Console.WriteLine(resultado);

            Console.WriteLine("-------------");

            Console.WriteLine(a.StartsWith(" Pai"));
            Console.WriteLine(a.EndsWith("Pobre"));

            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.ToLower());
            Console.WriteLine("-------------------------------------");

            string data = "30/03/2023";

            string [] date = data.Split('/');
            Console.WriteLine("Dia: " + date[0]);
            Console.WriteLine("Mes: " + date[1]);
            Console.WriteLine("Ano: " + date[2]);
        }
    }
}
