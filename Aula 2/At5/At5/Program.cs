using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min, seg;
            Console.Write("Coloque os segundos para serem convertidos para minitos:");
            seg = int.Parse(Console.ReadLine());
            min = seg / 60;
            if (min > 1)
            {
                Console.Write("Mais de um minuto");
            }
            Console.ReadKey();
        }
    }
}
