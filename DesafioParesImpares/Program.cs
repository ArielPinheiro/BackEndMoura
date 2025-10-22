/*int qntdletras = 0;
string nome = "";

Console.WriteLine($"Ola usuario quantas letras tem o seu nome");
qntdletras = int.Parse(Console.ReadLine());

for (int i = 1; i <= qntdletras; i++)
{
    Console.WriteLine($"Qual é a {i}ª letra");
    nome = nome + Console.ReadLine();
}

Console.WriteLine($"Seu nome é: {nome}");*/

int qntdNumeros;
string pares = "Pares: ";
string impares = "Impares: ";

Console.WriteLine("Olá! Quantos números você quer digitar?");
qntdNumeros = int.Parse(Console.ReadLine());

for (int i = 1; i <= qntdNumeros; i++)
{
    Console.WriteLine($"Qual é o {i}º número?");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        pares += numero + " ";
    }
    else
    {
        impares += numero + " ";
    }
}

Console.WriteLine(pares);
Console.WriteLine(impares);