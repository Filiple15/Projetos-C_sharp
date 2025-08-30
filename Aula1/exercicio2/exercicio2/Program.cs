using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Base1, Base2, A, Area;
            Console.WriteLine("Medida da base maior: ");
            Base1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Medida da base menor: ");
            Base2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Altura do trapezio: ");
            A = double.Parse(Console.ReadLine());
            Area = (Base1 * Base2) * A / 2;
            Console.WriteLine("A area do trapezio é de: " + Area);
            Console.ReadKey();
        }
    }
}
