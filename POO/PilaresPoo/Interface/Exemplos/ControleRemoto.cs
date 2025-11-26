namespace Exemplos
{

    public class ControleRemoto : IControle
    {
        public int NivelVolume = 0;
        public int VolumeMaximo = 30;
        public void AumentarVolume()
        {
            if (NivelVolume == VolumeMaximo)
            {
                Console.WriteLine($"Volume Maximo Alcançado");
                return;
            }
            Console.WriteLine($"Aumentando Volume: {NivelVolume} ");
        }
        public void Desligar()
        {
            Console.WriteLine($"Desligando  Puf");
        }

        public void DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
                Console.WriteLine($"Volume Ja esta no minimo: {NivelVolume}");
                return;
            }
            Console.WriteLine($"Diminuir volume: || || || || || || ||");
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando Plin");
        }
    }
}