using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // ContaCorrente conta = new ContaCorrente(); dá erro
            ContaCorrente conta = new ContaCorrente(0, 0);

            Console.ReadLine();
        }
    }
}
