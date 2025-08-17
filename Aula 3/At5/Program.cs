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

            if (n1 > n2)
            {
                Console.WriteLine("O primeiro número é maior que o segundo.");
            }
            else if (n1 < n2)
            {
                Console.WriteLine("O segundo número é maior que o primeiro.");
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
            Console.ReadKey();
        }
    }
}
