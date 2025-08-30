using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco1, preco2, preco3;

            Console.Write("Digite o preço do primeiro produto: ");
            preco1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o preço do segundo produto: ");
            preco2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o preço do terceiro produto: ");
            preco3 = double.Parse(Console.ReadLine());

            if (preco1 < preco2 && preco1 < preco3)
            {
                Console.WriteLine("O primeiro produto é o mais barato.");
            }
            else if (preco2 < preco1 && preco2 < preco3)
            {
                Console.WriteLine("O segundo produto é o mais barato.");
            }
            else
            {
                Console.WriteLine("O terceiro produto é o mais barato.");
            }
        }
    }
}
