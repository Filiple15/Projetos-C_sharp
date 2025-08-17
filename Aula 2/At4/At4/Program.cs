using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, aumento, novo;
            Console.Write("Digite o seu salario: ");
            salario = double.Parse(Console.ReadLine());
            if (salario < 1500)
            {
                aumento = salario * 0.37;
                novo = salario + aumento;
                Console.WriteLine("Seu salario é de: " + novo);
            }
            Console.ReadKey();
        }
    }
}
