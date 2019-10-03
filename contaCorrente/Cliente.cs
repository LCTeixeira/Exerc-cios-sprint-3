namespace contaCorrente{
    public class Conta{
        public string Titular;
        public int Agencia;
        public int Numero;
        public double Saldo = 0;

        public Conta(string titular, int agencia, int numero, double saldo)
        {
        this.Titular = titular;
        this.Agencia = agencia;
        this.Numero = numero;
        this.Saldo = saldo;
        }
    }
}    