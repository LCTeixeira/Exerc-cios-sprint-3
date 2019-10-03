using System;

namespace McBonalds
{
    public class Cliente
    {
        //Prorpiedades
    public string Nome;     //Nome do Cliente
    public string Endereço; //Endereço do Cliente
    public string Telefone; //Telefone do Cliente
    public string Senha;    //Senha de acesso do cliente ao sistema
    public string Email;    //Email do cliente e nome de usuario do sistema
    public DateTime DataNascimento; //Data de nascimento do cliente

    //Construtores
         public Cliente(string Nome, string Telefone, string Email){
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
        }
    }
}
