namespace Exercicio2
{
    public class Contrato : IImprimivel
    {
        public string Nome;
        public string TextoClausula;

        public Contrato(string nome, string Clausula)
        {
            Nome = nome;
            TextoClausula = Clausula;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo o Contrato...");
            Console.WriteLine($@"
            Nome: {Nome}            
            Contrato: {TextoClausula}
            ");
        }
    }

}