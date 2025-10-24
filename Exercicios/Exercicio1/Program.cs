//Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela
// “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” 
// se o valor gasto ultrapassar o valor do salário.

double salario;
double totalgasto;

Console.WriteLine("Qual o Valor do Seu Salario:");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Qual o Valor total gasto:");
totalgasto = double.Parse(Console.ReadLine());

if (salario >= totalgasto)
{
    Console.WriteLine("Gastos Dentro Do Orçamento");
}
else
{
        Console.WriteLine("Orçamento estourado");
}