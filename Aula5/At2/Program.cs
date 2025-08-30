using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if ((idade <=17) || (idade >= 65))
            {
                Console.WriteLine("Você não precisa votar");
            }
            else
            {
                Console.WriteLine("Voto obrigatorio");
            }
        }
    }
}
