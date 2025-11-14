using Exercicio03;

Carro C1 = new Carro();
Moto M1 = new Moto();

C1.Marca = "Toyota";
C1.Modelo = "Corolla";
C1.NumeroDePortas = 4;

M1.Marca = "Honda";
M1.Modelo = "CG 160";
M1.TipoCapacete = "Fechado";

Console.WriteLine("Informações dos veículos:\n");

C1.MostrarInfo();
Console.WriteLine();

M1.MostrarInfo();
