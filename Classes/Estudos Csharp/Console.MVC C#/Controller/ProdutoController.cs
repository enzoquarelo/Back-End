using Console.MVC_C_.Model.Model;
using Console.MVC_C_.Model.View;

namespace Console.MVC_C_.Model.Controller
{
    public class ProdutoController
    {
        // Instanciar objeto produto e produtoView
        Produto produto = new Produto();
        ProdutoView pView = new ProdutoView();
        public void ListarProdutos()
        {
            // lista de pordutos chamada pela model
            List<Produto> produtos = produto.Ler();

            // chamado método de exibição (VIEW) recebendo como argumento a l
            pView.Listar(produtos);
        }
    }
}