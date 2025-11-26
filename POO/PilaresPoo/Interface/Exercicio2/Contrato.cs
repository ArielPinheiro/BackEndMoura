namespace Exercicio2
{
    public class Contrato : IImprimivel
    {
        public string Nome;
        public string TextoClausula;
        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo o Contrato...");
        }
    }

}