using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ByteBamk - Cadastro de Clientes");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            System.Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            
            Cliente cliente1 = new Cliente(nome,cpf,email);

            bool trocouSenha = false;
            do{
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocaSenha(senha);
                if (trocouSenha){
                    System.Console.WriteLine("Senha alterada com sucesso");
                }else{
                    System.Console.WriteLine("Senha invalida");
                }
            }while(!trocouSenha);

        }
    }
}
