using Microsoft.VisualBasic;

namespace Exercicio2
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasAtraso = 0;
        public float juros = 0.10f;

        public Fatura(string nomeDevedor, string nomeEmpresa, float valorFatura, int qtdDiasAtraso)
        {
            Devedor = nomeDevedor;
            Credor = nomeEmpresa;
            Valor = valorFatura;
            DiasAtraso = qtdDiasAtraso;
        }

        public void CalcullarValorDivida()
        {
            if (DiasAtraso > 0)
            {
                Valor = Valor + DiasAtraso * juros;
            }
            else if (DiasAtraso >= 5)
            {
                Console.WriteLine($"Divida Encaminhada para o SERASA");

            }
        }
        public void Imprimir()
        {
            Console.WriteLine($@"
            Credor: {Credor}
            Devedor: {Devedor}
            Dias De Atraso: {DiasAtraso}
            Juros: {juros * DiasAtraso}
            Valor Total: {Valor}
            ");

        }
    }
}