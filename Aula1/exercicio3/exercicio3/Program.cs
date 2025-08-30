using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P, A;
            double IMC;
            Console.WriteLine("Informe o seu peso: ");
            P = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a sua altura: ");
            A = double.Parse(Console.ReadLine());
            IMC = P / (A * A);
            Console.WriteLine("O seu IMC é de: " + IMC);
            Console.ReadKey();
        }
    }
}
