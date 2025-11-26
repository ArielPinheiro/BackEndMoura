using ClassesEstaticas;
/*
Console.WriteLine($"Digite O Primeiro Numero");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite O Segundo Numero");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Resultados: ");
Console.WriteLine($"Soma: {CalculosMatematicos.Somar(n1, n2)}");
Console.WriteLine($"Subtração: {CalculosMatematicos.Subtrair(n1, n2)}");
Console.WriteLine($"Multiplicação: {CalculosMatematicos.Multiplicar(n1, n2)}");
Console.WriteLine($"Divisão: {CalculosMatematicos.Dividir(n1, n2)}");
*/


Console.WriteLine($"Digite O Primeiro Numero");
float N1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite O Segundo Numero");
float N2 = float.Parse(Console.ReadLine());

float maior = Math.Max(N1,N2);
float menor = Math.Min(N1,N2);

