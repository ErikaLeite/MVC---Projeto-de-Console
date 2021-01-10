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
        public void Cadastrar()
        {
            //Utilizamos um método criado em Model e acessamos o produto/método criado dentro de View como argumento
            produto.Inserir( prodView.CadastrarItem() );
        }
    }
}