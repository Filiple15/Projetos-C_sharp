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
            double altura, peso, imc;
            Console.Write("Coloque a sua altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Coloque O seu peso: ");
            peso = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);
            if (imc < 18.5)
            {
                Console.Write("Você está abaixo do peso normal");
            }
            Console.ReadKey();
        }
    }
}
