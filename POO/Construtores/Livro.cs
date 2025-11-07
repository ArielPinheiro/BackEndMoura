using System;

namespace Construtores
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public double Preco;

        public Livro(string titulo, string autor, double preco)
        {
            Titulo = titulo;
            Autor = autor;
            Preco = preco;
        }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Preco = 0.0;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Preço: R${Preco}");
        }
    }

}