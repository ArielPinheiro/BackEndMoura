using System;

namespace Construtores
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public Retangulo()
        {
            Largura = 1;
            Altura = 1;
        }

        public double CalcularArea()
        {
            return Largura * Altura;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Largura: {Largura}, Altura: {Altura}, Área: {CalcularArea()}");
        }
    }

}