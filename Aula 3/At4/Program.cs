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
            double resgate, saldoAtual;

            Console.Write("Coloque o valor que deseja sacar: ");
            resgate = double.Parse(Console.ReadLine());

            saldoAtual = 1000.00 - resgate;

            if (resgate > 1000)
            {
                Console.WriteLine("Valor acima do permitido.");
            }
            else
            {
                Console.WriteLine("Saque realizado com sucesso, agora seu saldo atual é de (" + saldoAtual + ").");
            }
            Console.ReadKey();
        }
    }
}
