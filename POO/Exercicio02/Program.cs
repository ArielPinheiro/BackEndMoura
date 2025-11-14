using System.Net.WebSockets;
using Exercicio02;

Gerente G1 = new Gerente();
Funcionario F1 = new Funcionario();

F1.SalarioBase = 1000;
G1.SalarioBase = 10000;

float SalarioFinalF = F1.CalcularSalario();
float SalarioFinalG = G1.CalcularSalario();

Console.WriteLine($"Salario Do Funcionario: {SalarioFinalF}");
Console.WriteLine($"Salario Do Gerente: {SalarioFinalG}");