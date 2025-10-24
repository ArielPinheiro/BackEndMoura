string[] nomes = new string[5];
float[] Saldo = new float[5];
int totalClientes = 0;


int opcao;
do
{
    Console.Clear();
    Console.WriteLine($"====Agencia Moura====");
    Console.WriteLine($"1) cadastrar cliente");
    Console.WriteLine($"2) Sacar");
    Console.WriteLine($"3) transferir");
    Console.WriteLine($"4) listar clientes");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando");
            break;
        case 1:
            CadastrarCliente();
            break;
        case 2:
            Sacar();
            break;

        case 3:
            transferir();
            break;

        case 4:
            listarclientes();
            break;

        default:
            Console.WriteLine($"Opção inválida");

            break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void listarclientes()
{
    Console.WriteLine($"=== Listagem de Clientes ===");

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"Nome: {nomes[i]} , {Saldo[i]} Saldo");

    }
}

void Sacar()
{
    Console.WriteLine($"");
}

void transferir()
{
    Console.WriteLine($"");
}


void CadastrarCliente()
{
    Console.WriteLine($"=== Cadastro de Clientes ===");

    //verificar se eu posso cadastrar
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de vagas atingido");
        return;
    }

    Console.WriteLine($"Digite o nome do cliente");
    nomes[totalClientes] = Console.ReadLine();

    Console.WriteLine($"Digite o Saldo de {nomes[totalClientes]}");
    Saldo[totalClientes] = int.Parse(Console.ReadLine());
    totalClientes++;
    Console.WriteLine($"Cliente cadastrado com sucesso!");
}