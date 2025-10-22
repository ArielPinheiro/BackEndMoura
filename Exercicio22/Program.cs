//Forma Rapida e Pratica de fazer
string Impar = "";

for (int i = 1; i <= 50; i = i + 2)
{
    Console.WriteLine($"Os números ímpares são:{i}");
}
Console.WriteLine("Os números ímpares são:");
Console.WriteLine(Impar);


//Duas Formas de Fazer o For essa aq é a forma correta
/*string impares = "";

for (int i = 0; i <= 50; i++)
{
    if (i % 2 == 1)
    {
        impares += i + " ";
    }
}

Console.WriteLine("Os números ímpares são:");
Console.WriteLine(impares);*/