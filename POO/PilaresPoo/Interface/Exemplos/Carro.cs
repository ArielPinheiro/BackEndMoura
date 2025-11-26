
namespace Exemplos
{
    public class Carro : IMotor
    {
        public string Cor;

        public string Marca;

        public string Modelo;

        public int Ano;

        public Carro(string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }
        public void ExibirInfo()
        {
            Console.WriteLine($@"Informaçôes do Veiculo: 
               Marca: {Marca}
               Modelo: {Modelo}
               Ano: {Ano}
               Cor: {Cor}
            ");
            
        }

        public void Acelerar()
        {
            Console.WriteLine($"vrummmm vrummmmmmmmmmm vrummmmmmmmmmmmmmmmmmmm");
        }

        public void Frear()
        {
            Console.WriteLine($"irrrrrrrrr...");
        }
    }
}