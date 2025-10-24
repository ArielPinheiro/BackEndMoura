int quantidade;
double total;

Console.WriteLine("Quantas maçãs você quer comprar?");
quantidade = int.Parse(Console.ReadLine());

if (quantidade < 12)
{
    total = quantidade * 0.30;
}
else
{
    total = quantidade * 0.25;
}

Console.WriteLine($"O valor total da compra é: R$ {total}");

