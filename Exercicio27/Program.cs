int quantidade;
int contador = 0;
int numero;

Console.WriteLine("Quantos números você quer digitar?");
quantidade = int.Parse(Console.ReadLine());

while (contador < quantidade)
{
    Console.WriteLine("Digite um número:");
    numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine($"Número par: {numero}");
    }

    contador++;
}