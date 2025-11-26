
namespace Exercicio01
{
    public class Carro
    {
        private string Marca;
        private string Modelo;
        private int velocidadeAtual;


        //métodos públicos para definir e obter a marca:
        public void DefinirMarca(string Honda)
        {
            Marca = Honda;
        }

        public void ObterMarca()
        {
            Console.WriteLine($"A Marca do carro e {Marca}");

        }

        //métodos públicos para definir e obter o modelo:
        public void DefinirModelo(string Conversivel)
        {
            Modelo = Conversivel;
        }

        public void ObterModelo()
        {
            Console.WriteLine($"A Modelo do carro e {Modelo}");
        }

        //método público para obter a velocidade atual:
        public void ObterVelocidade()
        {
            Console.WriteLine($"O Carro esta a {velocidadeAtual}Km/h");

        }

        //métodos públicos que alterem a velocidade do carro:
        public void Acelerar(int velocidade)
        {
            velocidadeAtual += velocidade;
            Console.WriteLine($"O Carro estava {velocidadeAtual}Km/h");

        }

        public void Frear(int velocidade)
        {
            if (velocidadeAtual <= 0)
            {
                Console.WriteLine($"O Carro ja esta Parado");
                return;
            }
            velocidadeAtual -= velocidade;
            Console.WriteLine($"O Carro freiou {velocidadeAtual}Km/h");

        }
    }
}