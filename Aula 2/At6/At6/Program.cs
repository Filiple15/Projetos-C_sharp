using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco, desconto, novo;
            Console.Write("Coloque o valor da compra: ");
            preco = double.Parse(Console.ReadLine());
            desconto = preco * 0.10;
            novo = preco - desconto;
            if (preco > 500)
            {
                Console.WriteLine("Você recebeu um desconto de 10%, o novo valor agora é de " +novo+ " .");
            }
            Console.ReadKey();
        }
    }
}
