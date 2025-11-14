namespace Exercicio02
{
    public class Gerente : Funcionario
    {
        public float BonusSalarial;
        public override float CalcularSalario()
        {
           return SalarioBase += BonusSalarial;
        }
    }
}