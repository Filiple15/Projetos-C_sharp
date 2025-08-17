using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 16)
            {
                Console.WriteLine("Você pode votar!");
            }

            else
            {
                Console.WriteLine("Você não pode votar");
            }
            Console.ReadKey();
        }
            
    }
}
