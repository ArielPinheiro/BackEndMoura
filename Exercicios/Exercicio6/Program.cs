double media;
double frequencia;

Console.WriteLine("Digite a média do aluno:");
media = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a frequência do aluno (em %):");
frequencia = double.Parse(Console.ReadLine());

if (frequencia < 75)
{
    Console.WriteLine("Aluno reprovado por frequência insuficiente.");
}
else // frequência >= 75
{
    if (media >= 7.0)
    {
        Console.WriteLine("Aluno aprovado!");
    }
    else if (media >= 3.0)
    {
        Console.WriteLine("Aluno em recuperação.");
    }
    else // média < 3
    {
        Console.WriteLine("Aluno reprovado por média insuficiente.");
    }
}
