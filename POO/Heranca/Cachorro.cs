
namespace Heranca
{
    public class Cachorro : Animal
    {
        public string Nome;
        public string Raca;
        public string idade;
    }
    public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome} Raca: {Raca} Idade:{idade}");
        }
}