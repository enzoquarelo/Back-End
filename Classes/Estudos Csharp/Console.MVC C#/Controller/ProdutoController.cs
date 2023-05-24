using Console.MVC_C_.Model;
using Console.MVC_C_.View;

namespace console_MVC.Controller
{
    public class ProdutoController
    {
        //instanciar objeto produto e produtoView

        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        // metodo controlador para acessar a listagem de produtos 
        public void ListarProdutos()
        {
            // lista de produtos chamada pela model 
            List<Produto> produtos = produto.Ler();

            // chamada do metodo de exibicao (View) recebendo como argumento a lista de produtos
            produtoView.Listar(produtos);
        }
    }
}