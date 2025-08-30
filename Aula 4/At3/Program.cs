using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Coloque o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Coloque o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("Valores iguais");
            }
            else if (n1 > n2)
            {
                Console.WriteLine("Primeiro maior");
            }
            else
            {
                Console.WriteLine("Segundo maior");
            }
            Console.ReadKey();
        }
    }
}
