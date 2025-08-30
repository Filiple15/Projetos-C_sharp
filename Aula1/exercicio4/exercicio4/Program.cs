using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double CP, CM, CG, valor;
            Console.WriteLine("Camisetas pequenas: ");
            CP = double.Parse(Console.ReadLine())*(30);
            Console.WriteLine("Camisetas medias: ");
            CM = double.Parse(Console.ReadLine())*(32);
            Console.WriteLine("Camisetas grandes: ");
            CG = double.Parse(Console.ReadLine())*(35);
            valor = CP + CM + CG;
            Console.WriteLine("O valor total de camisetas pequenas é de: " + CP);
            Console.WriteLine("O valor total de camisetas medias é de : " + CM);
            Console.WriteLine("O valor total de camisetas grandes é de: " + CG);
            Console.WriteLine("O valor total é de: " + valor);
            Console.ReadLine();
        }
    }
}
