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
            double Salario, n1, n2;

            Console.Write("Digite o salário: ");
            Salario = double.Parse(Console.ReadLine());

            n1 = (Salario * 0.37) + Salario;
            n2 = (Salario * 0.42) + Salario;

            if (Salario <= 1000.00)
            {
                Console.Write("O seu novo salario é de: " + n1);
            }

            else
            {
                Console.Write("O seu novo salario é de: " + n2);
            }
            Console.ReadKey();
        }
    }
}
