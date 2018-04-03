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

            cliente.nome = "Gabriela";
            cliente.cpf = "444.444.444-44";
            cliente.profissao = "Gerente de TI";

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.SetTitular(cliente);
            contaGabriela.SetAgencia(444);
            contaGabriela.SetNumero(444444);

            Console.WriteLine("cliente.nome: " + cliente.nome);
            Console.WriteLine("contaGabriela.titular.nome: " + contaGabriela.titular.nome);

            Console.WriteLine();
            
        }
    }
}
