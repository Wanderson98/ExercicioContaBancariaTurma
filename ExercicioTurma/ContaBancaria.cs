

namespace ExercicioTurma
{
    internal class ContaBancaria
    {
        public int NumeroDaConta { get; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroDaConta, string titular, double saldo)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
            Saldo = saldo;
        }

        public ContaBancaria(int numeroDaConta, string titular)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
           
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + 5.00);
        }

        public void AlteracaoNomeTitular(string nome)
        {
            Titular = nome;
        }

        public override string ToString()
        {
            return "\nTitular: " + Titular +  " Conta Número: " + NumeroDaConta + " Saldo de: R$ " + Saldo.ToString("F2") + "\n";
        }
    }
}
