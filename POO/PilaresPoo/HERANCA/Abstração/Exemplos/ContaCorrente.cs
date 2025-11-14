namespace Exemplo
{
    public class ContaCorrente : ContaBancaria
    {
        public override void Sacar(double valor)
        {
            double taxa = valor * 0.5;
            Saldo = valor + taxa;
        }
    }
}
