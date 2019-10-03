using System;

namespace contaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Titular:");
        string Titular = Console.ReadLine();
        System.Console.WriteLine("Agencia:");
        int Agencia = Console.ReadLine();
        System.Console.WriteLine("Numero:");
        int Numero = Console.ReadLine();
        
        Conta conta1 = new Conta(titular, agencia, numero, saldo);
        do{("Saldo:");
        double Saldo = Console.ReadLine();
        }
        }
    }
}
