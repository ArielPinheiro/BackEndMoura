namespace Exercicio1
{
  public class Circulo : IForma
  {
    public double Raio;

    public double CalcularArea()
    {
      return Math.PI * Raio * Raio;
    }
  }
}