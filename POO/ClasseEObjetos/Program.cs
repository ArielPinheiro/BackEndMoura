using ClasseEObjetos; //importa todas as classes da pasta/namespace
/*namespace ClasseEObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();
            conta.Titular = "Eduardo Mendes";
            Console.Clear();
            int opcao = 0;
            while (opcao != 4)
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Ver Saldo");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o valor do depósito: ");
                        double valorDeposito = double.Parse(Console.ReadLine());
                        conta.Depositar(valorDeposito);
                        break;
                    case 2:
                        Console.Write("Digite o valor do saque: ");
                        double valorSaque = double.Parse(Console.ReadLine());
                        conta.Sacar(valorSaque);
                        break;
                    case 3:
                        Console.WriteLine($"Saldo atual: R${conta.Saldo}\n");
                        break;
                    case 4:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.\n");
                        break;
                }
            }
        }
    }
}*/




namespace ClasseEObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Console.Clear();
            Console.Write("Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: R$");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.Clear();

            int opcao = 0;

            while (opcao != 4)
            {
                Console.WriteLine("=== MENU DO PRODUTO ===");
                Console.WriteLine($"Produto: {produto.Nome}");
                Console.WriteLine($"Preço atual: R${produto.Preco:F2}\n");

                Console.WriteLine("1 - Aplicar desconto");
                Console.WriteLine("2 - Alterar nome");
                Console.WriteLine("3 - Alterar preço");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o percentual de desconto: ");
                        double percentual = double.Parse(Console.ReadLine());
                        produto.AplicarDesconto(percentual);
                        break;

                    case 2:
                        Console.Write("Digite o novo nome do produto: ");
                        produto.Nome = Console.ReadLine();
                        Console.WriteLine("Nome alterado com sucesso!\n");
                        break;

                    case 3:
                        Console.Write("Digite o novo preço do produto: R$");
                        produto.Preco = double.Parse(Console.ReadLine());
                        Console.WriteLine("Preço alterado com sucesso!\n");
                        break;

                    case 4:
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente.\n");
                        break;
                }
            }
        }
    }
}