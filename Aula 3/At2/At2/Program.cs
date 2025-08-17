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
            String nome;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            if (nome == "andreia")
            {
                Console.Write("Você é a Prof");
            }

            else
            {
                Console.Write("Você deve ser um aluno ou aluna");
            }
            Console.ReadKey();b
        }
    }
}
