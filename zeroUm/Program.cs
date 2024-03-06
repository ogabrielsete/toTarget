using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeroUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k += 1;
                soma += k;
            }
            Console.WriteLine(soma);
        }
    }
}
