using System;
using System.Collections.Generic;
using MVC___Projeto_de_Console.Models;

namespace MVC___Projeto_de_Console.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos)
        {
           foreach (Produto item in produtos)
           {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: R$ {item.Preco}");
                Console.WriteLine($"");
                
           }
            
        }
        public Produto CadastrarItem()
        {
            Produto produto = new Produto();

            Console.WriteLine($"Insira o código do produto:");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Insira o nome do produto");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"Insira o preço do produto");
            produto.Preco = float.Parse(Console.ReadLine());
            
            return produto;
        }
    }
}