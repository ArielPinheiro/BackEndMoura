namespace Exercicio2
{
    public class Relatorio : IImprimivel
    {
        public string NomeResponsavel;
        public string TextoRelatorio;

        public Relatorio(string Responsavel, string Relatorio)
        {
            NomeResponsavel = Responsavel;
            TextoRelatorio = Relatorio;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Fazendo Relatorio...");
            Console.WriteLine($@"
            Nome Do Responsavel: {NomeResponsavel}            
            Relatorio: {TextoRelatorio}
            ");
            
        }
    }
}