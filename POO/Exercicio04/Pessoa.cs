namespace Exercicio04
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
        }
    }
}
