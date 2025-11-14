using Exercicio05;

ContaPoupanca CP1 = new ContaPoupanca();

CP1.Numero = 123;
CP1.Saldo = 0;

Console.WriteLine("=== CONTA POUPANÇA ===");
Console.WriteLine($"Número da Conta: {CP1.Numero}");

CP1.Depositar(1000);
Console.WriteLine($"Saldo após depósito: {CP1.Saldo}");

CP1.CalcularRendimento();
Console.WriteLine($"Saldo após rendimento: {CP1.Saldo}");
