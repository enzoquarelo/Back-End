using Console.MVC_C_.Model;

namespace Console.MVC_C_.View
{
    public class ProdutoView
    {
        // método para exibir os dados da lista de produtos
        public void Listar(List<Produto> produto)
        {
            Console.Clear();
            // foreach para ler a lista passada como parâmetro do método
            foreach (var item in produto)
            {
                Console.WriteLine(@$"
Código: {item.Codigo}
Nome:   {item.Nome}
Preco:  {item.Preco}");

            }
        }
    }
}