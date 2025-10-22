int contador = 1;

Console.WriteLine("Quantas vezes vc quer rodar o while");

int qntdVezes = int.Parse(Console.ReadLine());
while (contador <= qntdVezes)
{
    Console.WriteLine($"Contador é:{contador}");
    contador++;
}