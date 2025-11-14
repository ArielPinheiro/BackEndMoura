namespace Heranca
{
    public class Funcionario
    {
        public string Nome;
        public int SalarioBase;

         public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salario {SalarioBase}");
            
        }
    }
}