using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, A;
            double Area;
            Console.WriteLine("Coloque a medida do raio do circulo: ");
            R = double.Parse(Console.ReadLine());
            Area = (R * R) * 3.14;
            Console.WriteLine("A area é de: " + Area);
            Console.ReadKey();
        }
    }
}
