using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
   
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>()
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada de Game of Thrones", 99.9),
                new Produto("Poster", 10.0)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            foreach(var item in carrinho)
            {
                //Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
            }

            //carrinho.RemoveAt(3);
            Console.WriteLine(carrinho.Count);
            foreach(var item in carrinho)
            {
                //Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
            }



        }
    }
}
