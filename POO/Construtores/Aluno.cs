using System;

namespace Construtores
{
    public class Aluno
    {
        public string Nome;
        public double Nota;

        public Aluno()
        {
            Nome = "Ariel";
            Nota = 10;
        }

        public Aluno(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Aluno: {Nome}, Nota: {Nota}");
        }
    }
}