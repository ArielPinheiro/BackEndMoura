namespace Exercicio04
{
    public class Aluno : Pessoa
    {
        public string Curso;

        public override void MostrarInfo()
        {
            Console.WriteLine("=== ALUNO ===");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Curso: {Curso}");
        }
    }
}
