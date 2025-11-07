interface IAnimal //Define o "contrato" (métodos obrigatórios) //é obrigatorio começar com I no começo de toda interface
{
    void FazerSom();//Regra obrigatoria do "contrato"
    void Comer();//Regra obrigatoria do "contrato"
}
class Cachorro : IAnimal//Implementa os métodos de IAnimal com comportamento próprio(é obrigatorio ter as regras/comportamento)
{
    public void FazerSom()//Regra/comportamento
    {
        Console.WriteLine("Au! Au! Au! Au!");//ação do comportamento
    }
    public void Comer()//Regra/comportamento
    {
        Console.WriteLine("O cachorro está comendo ração premium.");//ação do comportamento
    }
}

class Gato : IAnimal//Implementa o mesmo contrato, mas com outra lógica e outro animal
{
    public void FazerSom()//Regra/comportamento
    {
        Console.WriteLine("Miaaauu!");//ação do comportamento
    }
    public void Comer()//Regra/comportamento
    {
        Console.WriteLine("O Gato está comendo peixe premium.");//ação do comportamento
    }
}


//fato curioso
//ah interface é uma heranca mas tem a diferenca que quando é vinculada a uma classe ela é obrigatoria ter os membro q ela tem e alem disso a interface te entrega oque fazer menos como fazer já a heranca não vc herda tudo já feito.