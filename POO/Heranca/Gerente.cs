
namespace Heranca
{
    public class Gerente : Funcionario
    {
        public int salariodogerente;

            
          public void ExibirInfo()
        {
            salariodogerente = SalarioBase * 2;
            
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salario {salariodogerente}");
            
        }
    }
}