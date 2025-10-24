int escolha;

do
{
    Console.Clear();
    Console.WriteLine($"-------------------------------");
    Console.WriteLine($"           Bem Vindo           ");
    Console.WriteLine($"               A               ");
    Console.WriteLine($"         Jacareca Food         ");
    Console.WriteLine($"-------------------------------");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Escolha Uma Das Opçóes Abaixo:");
    Console.WriteLine();
    Console.WriteLine($"1-Hot holl: R$29,90");
    Console.WriteLine($"2-Temaki: R$30,00");
    Console.WriteLine($"3-Sashimi: R$67,00");
    Console.WriteLine($"4-Yakisoba: R$58,00");
    Console.WriteLine($"5-Guioza: R$97,00");
    Console.WriteLine($"6-Shimeji: R$20,00");
    Console.WriteLine($"0-Sair");

    Console.Write("Digite o número do prato desejado: ");
    escolha = int.Parse(Console.ReadLine());
    switch (escolha)
    {
        case 0:
            Console.Write("Saindo ...");
            break;
        case 1:
            Hotroll();
            break;
        case 2:
            Temaki();
            break;
        case 3:
            Temaki();
            break;
        case 4:
            Sashimi();
            break;
        case 5:
            Yakisoba();
            break;
        case 6:
            Guioza();
            break;
        case 7:
            Shimeji();
            break;
        default:
            Console.Write("opção invalida:");
            break;
    }
    Console.WriteLine($"Digite Enter Para Continuar");
    Console.ReadLine();
} while (escolha != 0);

void Hotroll()
{
    Console.Write("Boa Escolha Vamos Preparar Seu Hot holl Com Carinho");
}
void Temaki()
{
    Console.Write("Boa Escolha Vamos Preparar Seu Temaki Com Carinho");
}
void Sashimi()
{
    Console.Write("Boa Escolha Vamos Preparar Seu Sashimi Com Carinho");
}
void Yakisoba()
{
    Console.Write("Boa Escolha Vamos Preparar Seu Yakisoba Com Carinho");
}
void Guioza()
{
    Console.Write("Boa Escolha Vamos Preparar Seu Guioza Com Carinho");
}
void Shimeji()
{
    Console.Write("Boa Escolha Vamos Preparar Seu Shimeji Com Carinho");
}