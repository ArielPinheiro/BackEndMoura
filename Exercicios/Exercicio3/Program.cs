//3) Escreva     um     programa que leia     as     medidas     dos     lados     de     um 
//triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     
// − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
// − Triângulo    Isóscele:    possui    2    lados    iguais.     
// − Triângulo    Escaleno:    possui    3    lados    diferentes.

double lado1;
double lado2;
double lado3;

Console.WriteLine("Digite o valor do primeiro lado:");
lado1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do segundo lado:");
lado2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do terceiro lado:");
lado3 = double.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("O triângulo é Equilátero.");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("O triângulo é Isósceles.");
}
else
{
    Console.WriteLine("O triângulo é Escaleno.");
}