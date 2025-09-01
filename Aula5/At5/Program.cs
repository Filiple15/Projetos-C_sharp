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
            int a, b, c;

            Console.Write("Digite o lado A do triangulo: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o lado B do triangulo: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o lado C do triangulo: ");
            c = int.Parse(Console.ReadLine());

            if ((a < b + c) || (b < a + c) || (c < a + b))
            {
                Console.Write("As medidas formam um triangulo");
            }
            else
            {
                Console.WriteLine("Nao forma um triangulo");
            }
            Console.ReadKey();
        }
    }
}
