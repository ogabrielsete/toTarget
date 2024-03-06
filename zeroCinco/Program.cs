using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeroCinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu texto: ");
            string s = Console.ReadLine();

            StringBuilder texto = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                texto.Append(s[i]);
            }
            Console.WriteLine($"Seu texto invertido é: {texto}");


        }
    }
}
