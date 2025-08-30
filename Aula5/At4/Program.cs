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
            int num1, num2, num3;

            Console.Write("Coloque o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Coloque o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Coloque o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 < num2 && num1 < num3)
            {
                if (num2 < num3)
                {
                    Console.Write("A ordem é: "+num1+", "+num2 +" e "+num3);
                }
                else
                {
                    Console.Write("A ordem é: "+num1+", "+num3 +" e "+num2);
                }
            }
            else if (num2 < num1 && num2 < num3)
            {
                if (num3 < num1)
                {
                    Console.Write("A ordem é: "+num2+", "+num3+" e "+num1);
                }
                else
                {
                    Console.Write("A ordem é: "+num2+", "+ num1+" e "+num3);
                }
            }
            else
            {
                Console.WriteLine("A ordem é: "+num3+", "+ num1+" e "+num2);
            }
            Console.ReadKey();
        }
    }
}
