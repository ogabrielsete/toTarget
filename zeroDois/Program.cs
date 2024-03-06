using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeroDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (EhFibonacci(numero))
            {
                Console.WriteLine("O número está em uma sequência de Fibonacci");
            }
            else
            {
                Console.WriteLine("O número não está em uma sequência de Fibonacci");
            }
        }

        static bool EhFibonacci(int numero)
        {
            int a = 0;
            int b = 1;

            while (a <= numero)
            {
                if (a == numero)
                {
                    return true;
                }

                int proximoNumero = a + b;
                a = b;
                b = proximoNumero;
            }

            return false;

        }
    }
}

