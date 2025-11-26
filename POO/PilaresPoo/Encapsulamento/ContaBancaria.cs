using System.Diagnostics.Contracts;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;




        public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial > 0)
            {
                Saldo = saldoInicial;
            } else
            {
                Saldo = 0;
            }


        }
        //Metodos Gets and Set


            


        public void Depositar(float Valor)
        {
            if (Valor > 0)
            {
                Console.WriteLine($"Valor Invalido");
            }
            else
            {
                Saldo += Valor;
            }
        }

        //Get do Saldo 

        public float GetSaldo()
        {
            return Saldo;
        }

        public void Sacar(float Valor)
        {
            if (Valor >= 0 && Valor <= Saldo)
            {
                Saldo -= Valor;
                Console.WriteLine($"Saque Efetuado Com Sucesso");
            }
            else
            {
                Console.WriteLine($"Saldo Insuficiente Ou Negativo");
            }
        }
    }
}

