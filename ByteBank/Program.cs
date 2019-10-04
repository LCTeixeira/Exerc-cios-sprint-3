using System;
using System.Reflection.Metadata;

namespace ByteBank {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("ByteBamk - Cadastro de Clientes");
            Console.Write ("Nome: ");
            string nome = Console.ReadLine ();
            Console.Write ("CPF: ");
            string cpf = Console.ReadLine ();
            System.Console.WriteLine ("Email: ");
            string email = Console.ReadLine ();

            Cliente cliente1 = new Cliente (nome, cpf, email);

            bool trocouSenha = false;
            do {
                Console.Write ("Senha: ");
                string senha = Console.ReadLine ();
                trocouSenha = cliente1.TrocaSenha (senha);
                if (trocouSenha) {
                    System.Console.WriteLine ("Senha alterada com sucesso");
                } else {
                    System.Console.WriteLine ("Senha invalida");
                }
            } while (!trocouSenha);
            Console.Clear ();

            System.Console.WriteLine ("Cadastro da Conta");
            Console.WriteLine ("Entre com a agencia");
            int agencia = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Entre com a conta");
            int conta = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ("Entre com o nome do titular");
            string titular = Console.ReadLine ();

            ContaCorrente contaCorrente1 = new ContaCorrente (agencia, conta, titular);
            double saldo;
            do {
                System.Console.WriteLine ("Entre com o saldo: ");
                saldo = double.Parse (Console.ReadLine ());
                if (saldo >= 0) {
                    contaCorrente1.Saldo = saldo;
                } else {
                    System.Console.WriteLine ("Valor do saldo deve ser positivo");
                }
            } while (saldo < 0);
        Console.Clear();

        System.Console.WriteLine("Insira o valor do deposito");
        Console.ReadLine();
        ContaCorrente Deposito = new ContaCorrente (Deposito, Saque, Transferencia);
        }
    }
}