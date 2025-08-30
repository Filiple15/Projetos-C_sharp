using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cor;

            Console.Write("Coloque a cor do semáforo: ");
            cor = Console.ReadLine().ToUpper();

            if (cor == "VERDE")
            {
                Console.WriteLine("Pode passar!");
            }
            else if (cor == "AMARELO")
            {
                Console.WriteLine("Atenção!");
            }
            else
            {
                Console.WriteLine("PARE!");
            }
            Console.ReadKey();
        }
    }
}
