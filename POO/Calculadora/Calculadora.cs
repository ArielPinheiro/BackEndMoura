
namespace Calculadora
{
    public class Calculator
    {
        public double N1;
        public double N2;
        public double Resultado;

        public double Somar()
        {
            Resultado = N1 + N2;
            Console.WriteLine($"Resultado da soma: {Resultado}");
            return Resultado;
        }
        public double Subtrair()
        {
            Resultado = N1 - N2;
            Console.WriteLine($"Resultado da subtração: {Resultado}");
            return Resultado; ;
        }
        public double Dividir()
        {
            if (N2 == 0)
            {
                Console.WriteLine($"Não existe divisão por zero");

            }
                Resultado = N1 / N2;
                Console.WriteLine($"Resultado da subtração: {Resultado}");
                return Resultado;
        }
        public double Multiplicar()
        {
            Resultado = N1 * N2;
            Console.WriteLine($"Resultado da multiplicação: {Resultado}");
            return Resultado;
        }
    }
}