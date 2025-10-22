// Perguntar ao usuario quantas letras tem o nome dele dps pedir letra a letra

int qntdletras = 0;
string nome = "";

Console.WriteLine($"Ola usuario quantas letras tem o seu nome");
qntdletras = int.Parse(Console.ReadLine());

for (int i = 1; i <= qntdletras; i++)
{
    Console.WriteLine($"Qual é a {i}ª letra");
    nome = nome + Console.ReadLine();
}

Console.WriteLine($"Seu nome é: {nome}");

//PERGUNTAR AO USUARIO QUANTOS NUMEROS ELE QUER DIGITAR E EXIBIR SEPARADAMENTE OS NUMEROS PARES E OS NUMEROS IMPARES QUE ELE DIGITAR

