using System;
using MVC___Projeto_de_Console.Controllers;
using MVC___Projeto_de_Console.Models;

namespace MVC___Projeto_de_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.Cadastrar();
            
            prod.MostrarProdutos();            
        }
    }
}
