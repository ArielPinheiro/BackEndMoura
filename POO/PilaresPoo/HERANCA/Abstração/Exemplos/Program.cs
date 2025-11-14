using System.Net.WebSockets;
using Exemplo;
/*
Gato Sheldon = new Gato();
Cachorro Paçoca = new Cachorro();
Pessoa Rafael = new Pessoa();

Rafael.Nome();
Rafael.Idade();

*/
//crie uma classe abstrata ContaBancaria com os metodos Depositar(double valor) e Sacar(double valor)
//crie duas classes ContaCorrente e ContaPoupanca cada uma com a sua forma de calcular o saldo apos o saque por exemplo taxas diferentes

ContaCorrente cc = new ContaCorrente();
ContaPoupanca cp = new ContaPoupanca();

cc.Depositar(500);
cp.Depositar(500);

Console.WriteLine("=== CONTA CORRENTE ===");
Console.WriteLine($"Saldo inicial: {cc.Saldo}");
Console.WriteLine($"Taxa De 5 Reis reis");
cc.Sacar(200);
Console.WriteLine($"Saldo após saque: {cc.Saldo}");

Console.WriteLine("\n=== CONTA POUPANÇA ===");
Console.WriteLine($"Saldo inicial: {cp.Saldo}");
Console.WriteLine($"Taxa De 1 Reis reis");
cp.Sacar(100);
Console.WriteLine($"Saldo após saque: {cp.Saldo}");

