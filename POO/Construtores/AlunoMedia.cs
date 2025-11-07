using System;

namespace Construtores
{
    public class AlunoMedia
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public AlunoMedia(string nome, double n1, double n2, double n3)
        {
            Nome = nome;
            Nota1 = n1;
            Nota2 = n2;
            Nota3 = n3;
        }

        public AlunoMedia()
        {
            Nome = "Sem nome";
            Nota1 = Nota2 = Nota3 = 0.0;
        }

        public double CalcularMedia()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public void ExibirMedia()
        {
            Console.WriteLine($"Aluno: {Nome}, Média: {CalcularMedia():F2}");
        }
    }

}