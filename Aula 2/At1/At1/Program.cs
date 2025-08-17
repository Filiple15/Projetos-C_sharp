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
            int idade;
            Console.Write("Coloque a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade >= 16)
            {
                Console.WriteLine("Você tem " + idade + " então você ja pode Votar");
            }

            Console.ReadKey();
        }
    }
}
