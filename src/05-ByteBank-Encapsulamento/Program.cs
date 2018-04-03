using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.SetNome("Gabriela");
            cliente.SetCpf("444.444.444-44");
            cliente.SetProfissao("Gerente de TI");

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.SetTitular(cliente);
            contaGabriela.SetAgencia(444);
            contaGabriela.SetNumero(444444);

            Console.WriteLine("cliente.GetNome(): " + cliente.GetNome());
            Console.WriteLine("contaGabriela.GetTitular().GetNome(): " + contaGabriela.GetTitular().GetNome());

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
