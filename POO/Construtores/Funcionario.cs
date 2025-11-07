
namespace Construtores
{
    public class Funcionario
    {
        public string Nome;
        public string Cargo;
        public double Salario;

        public Funcionario(string nome)
        {
            Nome = nome;
            Cargo = "Não definido";
            Salario = 0.0;
        }

        public Funcionario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = 0.0;
        }

        public Funcionario(string nome, string cargo, double salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Cargo: {Cargo}, Salário: R${Salario}");
        }
    }
}