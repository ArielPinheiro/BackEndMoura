using System;

namespace Construtores
{
    public class Computador
    {
        public string Marca;
        public int MemoriaRam;
        public int Armazenamento;

        public Computador()
        {
            Marca = "Genérico";
            MemoriaRam = 4;
            Armazenamento = 256;
        }

        public Computador(string marca, int memoriaRam, int armazenamento)
        {
            Marca = marca;
            MemoriaRam = memoriaRam;
            Armazenamento = armazenamento;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Marca: {Marca}, RAM: {MemoriaRam}GB, Armazenamento: {Armazenamento}GB");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computador comp1 = new Computador();
            Computador comp2 = new Computador("Dell", 16, 512);

            comp1.ExibirDados();
            comp2.ExibirDados();
        }
    }
}
