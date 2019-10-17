namespace ByteBank {
    public class ContaCorrente {
        private int conta;

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double _Saldo;

        public double Saldo {
            get { return _Saldo; }
        }
        public ContaCorrente (int agencia, int conta, Cliente Titular) {
            this.Agencia = agencia;
            this.conta = conta;
            this.Titular = Titular;
            this._Saldo = 0;
        }

        public bool Deposito (double valor) {
            if (valor >= 0) {
            this._Saldo += valor;
            return true;
            } else {
                return false;
            }
        }
        public bool Saque (double valor) {
            if (valor <= 0) {
                return false;
            } else {
                if (Saldo >= valor) {
                    _Saldo -= valor;
                    return true;
                } else {
                    return false;
                }
            }
        }
        public bool Transferencia (ContaCorrente contaDestino, double valor) {
            if (this.Saque (valor)) {
                contaDestino.Deposito (valor);
                return true;
            } else {
                return false;
            }
        }
    }
}