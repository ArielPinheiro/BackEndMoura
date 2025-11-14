namespace Exercicio03
{
    public class Carro : Veiculo
    {
        public int NumeroDePortas;

        public override void MostrarInfo()
        {
            Console.WriteLine("=== CARRO ===");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Número de Portas: {NumeroDePortas}");
        }
    }
}
