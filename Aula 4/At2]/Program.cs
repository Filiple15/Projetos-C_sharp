using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;

            Console.Write("Coloque o coeficiente a:");
            a = double.Parse(Console.ReadLine());

            Console.Write("Coloque o coeficiente b:");
            b = double.Parse(Console.ReadLine());

            Console.Write("Coloque o coeficiente c:");
            c = double.Parse(Console.ReadLine());

            delta = (b * b) - (4 * a * c);
            if (delta == 0)
            {
                Console.Write("A equação possui uma solução");
            }
            else if (delta > 0)
            {
                Console.Write("A equação possui duas soluções");
            }
            else
            {
                Console.Write("A equação não possui solução");
            }
            Console.ReadKey();
        }
    }
}
