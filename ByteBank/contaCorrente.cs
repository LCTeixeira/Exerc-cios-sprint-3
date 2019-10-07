namespace ByteBank {
    public class ContaCorrente {
        private int conta;

        public string Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente (int agencia, int conta, string titular) {
            this.Agencia = agencia;
            this.conta = conta;
            this.Titular = titular;
            this.Saldo = 0;
        }

        public double Deposito(double valor){
            return this.Saldo += valor;
        } 
        public bool Saque(double valor){
            if(Saldo >= valor){
                Saldo -= valor;
                return true;
            }else{
                return false;
            }
        }
        public bool Transferencia(ContaCorrente contaDestino, double valor){
            if(this.Saque(valor)){
                contaDestino.Deposito(valor);
                return true;
            }else{
                return false;
            }
        }
    }
}