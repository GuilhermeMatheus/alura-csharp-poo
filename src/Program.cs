﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            conta.agencia = 123;
            conta.numero = 123456;
            conta.saldo = 100;

            Console.WriteLine(conta.titular);

            Console.WriteLine("Saldo : " + conta.saldo);

            conta.saldo += 100;
            Console.WriteLine("Novo saldo : " + conta.saldo);

            conta.saldo = 10;
            Console.WriteLine("Novo saldo : " + conta.saldo);

            Console.ReadLine();
        }
    }
}