namespace Exercicio03
{
    public class Moto : Veiculo
    {
        public string TipoCapacete;

        public override void MostrarInfo()
        {
            Console.WriteLine("=== MOTO ===");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Tipo de Capacete: {TipoCapacete}");
        }
    }
}
