using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Digite um número:");
            num = double.Parse(Console.ReadLine());

            if ((num >= 0) && (10 >= num))
            {
                Console.Write("Numero está entre 0 e 10");
            }
            else
            {
                Console.Write("Numero não está entre 0 e 10");
            }
            Console.ReadKey();
        }
    }
}
