namespace Exemplo
{
    public class ContaPoupanca : ContaBancaria
    {
        public override void Sacar(double valor)
        {
            double taxa = valor * 0.3;
            Saldo -= valor + taxa;
        }
    }
}
