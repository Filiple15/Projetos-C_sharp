using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, resto;

            Console.Write("Coloque um numero inteiro: ");
            n1 = int.Parse(Console.ReadLine());

            resto = n1 % 2;

            if (resto == 0)
            {
                Console.WriteLine("O numero que você digitou é par");
            }
            else
            {
                Console.WriteLine("O numero que você digitou é impar");
            }
            Console.ReadKey();

        }
    }
}
