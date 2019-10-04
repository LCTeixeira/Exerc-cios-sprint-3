namespace ByteBank{
    public class ContaCorrente{
        private int conta;
        private ContaCorrente deposito;
        private object ;

        public string Titular{get;set;}
        public int Agencia{get;set;}
        public int Numero{get;set;}
        public double Saldo{get;set;}
        public double Deposito{get;set;}
        public double Saque{get;set;}
        public double Transferencia{get;set;}
        public ContaCorrente(int agencia, int conta, string titular, double Deposito, double Saque, double Transferencia)
        {
            this.Agencia = agencia;
            this.conta = conta;
            this.Titular = titular;
            this.Saldo = 0;
            this.Deposito = Deposito;
            this.Saque = Saque;
            this.Transferencia = Transferencia;
        }
        
    }
}    