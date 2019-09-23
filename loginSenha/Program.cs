using System;

namespace loginSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string senha;

            Console.WriteLine("Login");
            login = Console.ReadLine();

            Console.WriteLine("Senha");
            senha = Console.ReadLine();

            if((login=="admin") && (senha=="admin")){
                Console.WriteLine("Você é o Administrador");
            }

            else{
                Console.WriteLine("Bem vindo Usuário");
            }


        }
    }
}
