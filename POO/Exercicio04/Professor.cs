namespace Exercicio04
{
    public class Professor : Pessoa
    {
        public string Disciplina;

        public override void MostrarInfo()
        {
            Console.WriteLine("=== PROFESSOR ===");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Disciplina: {Disciplina}");
        }
    }
}
