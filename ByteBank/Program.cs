using System;
using System.Reflection.Metadata;

namespace ByteBank {
    class Program {
        static void Main (string[] args) {
            #region Cadastro do Cliente.
            #region Cadastro Conta.
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

            ContaCorrente contaCorrente1 = new ContaCorrente (agencia, conta, cliente1);
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
            Console.Clear ();
            #endregion

            Cliente cliente2 = new Cliente ("Cesar", "123.123.123.12", "1@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente (123, 321, cliente2);

            #region Deposito.
            Cliente usuario = contaCorrente1.Titular:
                System.Console.WriteLine ("ByteBank - Deposito em Conta");
            System.Console.WriteLine ($"Bem Vindo - {usuario.Nome}");
            System.Console.WriteLine ($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine ("Digite o valor do Deposito: ");
            double valor = double.Parse (Console.ReadLine ());
            contaCorrente1.Deposito (valor);
            System.Console.WriteLine ();
            System.Console.WriteLine ($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine ();
            #endregion

            #region Transferencia.
            System.Console.WriteLine ("ByteBank - Tranferencia");
            System.Console.WriteLine ($"Bem Vindo - {usuario.Nome}");
            System.Console.WriteLine ($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente1.Numero}");
            System.Console.WriteLine ($"Saldo Origem: {contaCorrente1.Saldo}");
            System.Console.WriteLine ($"Saldo Destino: {contaCorrente2.Saldo}");
            valor = double.Parse (Console.ReadLine ());
            contaCorrente1.Deposito (valor);
            System.Console.WriteLine ();
            System.Console.WriteLine ($"Novo Saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine ();
            #endregion
        }
    }
}