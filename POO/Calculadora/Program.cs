using Calculadora;
/*Console.Clear();

Calculator calc = new Calculator();

calc.N1 = 50;
calc.N2 = 20;

Console.WriteLine($"== Calculator ==");
Console.WriteLine($"Primeiro Numero: {calc.N1}");
Console.WriteLine($"Segundo Numero: {calc.N2}");

Console.WriteLine($"Resultados:");
Console.WriteLine($"{calc.N1}, {calc.N2}");
Console.WriteLine($"");

Console.WriteLine($"Multiplicação");
calc.Multiplicar();
Console.WriteLine();

Console.WriteLine($"Divisão");
calc.Dividir();
Console.WriteLine();
*/
            Calculator calc = new Calculator();
            int opcao = 0;

            while (opcao != 5)
            {
                Console.WriteLine("=== CALCULADORA ===");
                Console.WriteLine("===     Menu    ===");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o primeiro número: ");
                        calc.N1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        calc.N2 = double.Parse(Console.ReadLine());
                        calc.Somar();
                        break;

                    case 2:
                        Console.Write("Digite o primeiro número: ");
                        calc.N1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        calc.N2 = double.Parse(Console.ReadLine());
                        calc.Subtrair();
                        break;

                    case 3:
                        Console.Write("Digite o primeiro número: ");
                        calc.N1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        calc.N2 = double.Parse(Console.ReadLine());
                        calc.Multiplicar();
                        break;

                    case 4:
                        Console.Write("Digite o primeiro número: ");
                        calc.N1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        calc.N2 = double.Parse(Console.ReadLine());
                        calc.Dividir();
                        break;

                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente.\n");
                        break;
                }
            }
