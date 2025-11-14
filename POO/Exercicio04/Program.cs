using Exercicio04;

Aluno A1 = new Aluno();
Professor P1 = new Professor();

A1.Nome = "Carlos";
A1.Idade = 20;
A1.Curso = "Engenharia de Software";

P1.Nome = "Mariana";
P1.Idade = 35;
P1.Disciplina = "Matemática";

Console.WriteLine("Informações da Escola:");

A1.MostrarInfo();
Console.WriteLine();

P1.MostrarInfo();
