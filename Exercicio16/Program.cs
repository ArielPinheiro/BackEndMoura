/*int Idade;
string Nome;

Console.WriteLine("Olá Qual Seu Nome");//escreve um texto no console
Nome = Console.ReadLine(); //captura o nome do cliente digitado e guarda no console na variavel

Console.WriteLine("Qual A Sua Idade");
Idade = int.Parse(Console.ReadLine());

Console.WriteLine($"{Nome}, Obrigado Por Responder");

if (Idade >= 18)
{
    Console.WriteLine("Voce é maior de idade");
}
else
{
    Console.WriteLine("Voce é menor de idade");
}*/

/*double Salario;
string Cargo;

Console.WriteLine("Olá, qual seu cargo digite ele inteiro por favor");
Cargo = Console.ReadLine();

Console.WriteLine("Qual o seu salário?");
Salario = double.Parse(Console.ReadLine());

Console.WriteLine($"{Cargo}, obrigado por responder.");

if (Cargo == "Produção")
{
    Salario = Salario * 1.065;
    Console.WriteLine($"Seu novo salário é: R$ {Salario}");
}
else if (Cargo == "Administrativo")
{
    Salario = Salario * 1.075;
    Console.WriteLine($"Seu novo salário é: R$ {Salario}");
}
else if (Cargo == "Diretoria")
{
    Salario = Salario * 1.12;
    Console.WriteLine($"Seu novo salário é: R$ {Salario}");
}
else
{
    Console.WriteLine("Cargo não reconhecido.");
}*/

double Salario, SalarioNovo = 0;
string Cargo;

Console.WriteLine($"Digite o cargo do funcionario, Producao, Administrativo ou Diretoria");
Cargo = Console.ReadLine();

Console.WriteLine($"Digite qual o salario do funcionario");
Salario = double.Parse(Console.ReadLine());

if (Cargo == "Produção")
{
    SalarioNovo = Salario + (Salario * 0.065);
}
else if (Cargo == "Administrativo")
{
    SalarioNovo = Salario + (Salario * 0.075);
}
else if (Cargo == "Diretoria")
{
    SalarioNovo = Salario + (Salario * 0.12);
}
else
{
    Console.WriteLine($"Cargo Invalido");
}

    Console.WriteLine($"Novo Salario Reajustado {SalarioNovo}");
