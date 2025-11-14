namespace Exemplo
{
    public abstract class ContaBancaria
    {
        public double Saldo;

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public abstract void Sacar(double valor);
    }
}
