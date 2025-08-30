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
            double valor, d1, d2, d3;
            Console.WriteLine("Digite o valor da compra: ");
            valor = double.Parse(Console.ReadLine());

            d1 = (valor * 0.03);
            d2 = (valor * 0.05);
            d3 = (valor * 0.1);

            if (valor <= 2000)
            {
                Console.WriteLine("O valor do desconto é: " + d1);
            }
            else if (valor <= 3000)
            {
                Console.WriteLine("O valor do desconto é: " + d2);
            }
            else
            {
                Console.WriteLine("O valor do desconto é: " + d3);
            }
            Console.ReadKey();

        }
    }
}
