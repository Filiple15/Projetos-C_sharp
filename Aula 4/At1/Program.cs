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
            Console.Write("Coloque a idade do jogador: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 10)
            {
                Console.Write("infantil");
            }
            else if (idade <= 17)
            {
                Console.Write("Juvenil");
            }
            else
            {
                Console.Write("Adulto");
            }
            Console.ReadKey();
        }
    }
}
