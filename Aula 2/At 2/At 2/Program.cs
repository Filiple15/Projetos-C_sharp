using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome;
            Console.WriteLine("Coloque o seu nome: ");
            nome = Console.ReadLine();
            if (nome == "Andreia")
            {
                Console.WriteLine("Você é a professora Andreia !");
            }

            Console.ReadKey();
        }
    }
}
