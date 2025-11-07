
namespace Construtores
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa()
        {
            Nome = "Desconhecido";
            Idade = 0;
        }

        public Pessoa(string nome)
        {
            Nome = nome;
            Idade = 0;
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }

}