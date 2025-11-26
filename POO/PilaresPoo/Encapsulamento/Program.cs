using Encapsulamento;

ContaBancaria contaBaAri = new ContaBancaria(32);
ContaBancaria contaBaria = new ContaBancaria(1500);
contaBaAri.Depositar(-100);
contaBaAri.Depositar(20);
contaBaAri.Sacar(-200);
contaBaria.Sacar(300);

Console.WriteLine();

Console.WriteLine($"Saldo Atual Ariel : {contaBaAri.GetSaldo()}");
Console.WriteLine($"Saldo Atual Maria : {contaBaria.GetSaldo()}");