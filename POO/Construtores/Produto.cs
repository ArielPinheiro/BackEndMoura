using System;

namespace Construtores
{
    public class Produto
    {
        public string Nome;
        public float Preco;
        public int Estoque;

        public Produto(string nome, float preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Produto: {Nome}, Preço: R${Preco}, Estoque: {Estoque}");
        }
    }
}
