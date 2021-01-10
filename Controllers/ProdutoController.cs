using System.Collections.Generic;
using MVC___Projeto_de_Console.Models;
using MVC___Projeto_de_Console.Views;

namespace MVC___Projeto_de_Console.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView prodView = new ProdutoView();

        public void MostrarProdutos()
        {
            List<Produto> todos = produto.Ler();
            prodView.Listar(todos);
        }
    }
}