int x;
int contador = 0;
int num1, num2;

Console.WriteLine("Quantas vezes você quer repetir?");
x = int.Parse(Console.ReadLine());

while (contador < x)
{
    Console.WriteLine("Digite o primeiro número:");
    num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número:");
    num2 = int.Parse(Console.ReadLine());

    if (num1 > num2)
    {
        Console.WriteLine($"O maior número é: {num1}");
    }
    else if (num2 > num1)
    {
        Console.WriteLine($"O maior número é: {num2}");
    }
    else
    {
        Console.WriteLine("Os dois números são iguais!");
    }

    contador++;
}