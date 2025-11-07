
namespace ClasseEObjetos
{
    public class ContaBancaria
    {
        public string Titular;
        public double Saldo;

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser maior que R$0");
                return;
            }

            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado com sucesso!");
            Console.WriteLine($"Saldo atual: R${Saldo}\n");
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser maior que R$0");
                return;
            }

            if (valor > Saldo)
            {
                Console.WriteLine($"Saldo insuficiente. Saldo atual: R${Saldo}\n");
                return;
            }
            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor} realizado com sucesso!");
            Console.WriteLine($"Saldo atual: R${Saldo}\n");
        }
    }
}