namespace ByteBank
{
    public class Cliente
    {
        public string Nome {get; set;}
        public string CPF {get; set;}
        public string Email {get; set;}
        public string _Senha {get; set;}

public string Senha{
    get{return _Senha;}
}
        public Cliente(string Nome, string CPF, string Email)
        {
            this.Nome = Nome;
            this.CPF = CPF;
            this.Email = Email;
        }

        public bool TrocaSenha(string senha)
        {
        if ((senha.Length > 6) && (senha.Length < 16)){
            this._Senha = senha;
            return true;
        }else{
            return false;
        }
        }
    }
}