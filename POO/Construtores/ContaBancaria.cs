using System;

namespace Construtores
{
    public class ContaBancaria
    {
        public string Titular;
        public double Saldo;

        public ContaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public ContaBancaria(string titular)
        {
            Titular = titular;
            Saldo = 0.0;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Titular: {Titular}, Saldo: R${Saldo}");
        }
    }

}