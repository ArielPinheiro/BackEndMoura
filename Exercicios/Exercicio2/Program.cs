//2)Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time)
//  e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

double placar1;
double placar2;

Console.WriteLine("Qual placar do time 1");
placar1 = double.Parse(Console.ReadLine());
Console.WriteLine("Qual placar do time 2");
placar2 = double.Parse(Console.ReadLine());

if (placar1 >= placar2)
{
    Console.WriteLine("Time 1 Ganhou");
}
else if (placar1 <= placar2)
{
    Console.WriteLine("Time 2 Ganhou");
}
else
{
    Console.WriteLine("Houve um empate");
}