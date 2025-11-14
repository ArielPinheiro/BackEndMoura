namespace Exercicio05
{
    public class Conta
    {
        public int Numero;
        public float Saldo;

        public void Depositar(float valor)
        {
            Saldo += valor;
        }

        public void Sacar(float valor)
        {
            Saldo -= valor;
        }
    }
}
