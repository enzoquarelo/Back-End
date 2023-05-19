namespace ProjetoCadastro_16_05.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public int marcaProcurar { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca { get; set; }
        public Usuario Usuario { get; set; }
        public Usuario CadastradoPor { get; set; }
        public List<Produto> ListaDeProdutos { get; set; }
        Usuario ObjetoUsuario = new Usuario();
        public Produto()
        { }
        public Produto(string nomeProduto, float preco, Marca marca, Usuario cadastradoPor, DateTime dataCadastro, int codigo)
        {
            Codigo = codigo;
            NomeProduto = nomeProduto;
            Preco = preco;
            Marca = marca;
            CadastradoPor = cadastradoPor;
            DataCadastro = dataCadastro;
        }

        List<Produto> listProduto = new List<Produto>();

        Marca m = new Marca();
        public void Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Vamos realizar o cadastro do Produto");

            Console.Write($"Informe o codigo do Produto:");
            int codigo = int.Parse(Console.ReadLine());

            novoProduto = listProduto.Find(x => x.Codigo == codigo);

            if (novoProduto == null)
            {
                novoProduto = new Produto();
                novoProduto.Codigo = codigo;
                Console.Write($"Informe o nome do Produto:");
                novoProduto.NomeProduto = Console.ReadLine().ToUpper();

                Console.Write($"Informe o preco do Produto:");
                novoProduto.Preco = float.Parse(Console.ReadLine());
                DataCadastro = DateTime.Now;

                novoProduto.Marca = m.Cadastrar();

                listProduto.Add(novoProduto);
            }
            else
            {
                Console.WriteLine($"O produto ja existe! *{novoProduto.NomeProduto}*");
            }
        }
        public List<Produto> Listar()
        {
            foreach (var item in listProduto)
            {
                Console.WriteLine(@$"
                ╔═══════════════════════════════════════════════╗
                ║Nome do Produto : {item.NomeProduto}           ║  
                ║Codigo do Produto : {item.Codigo}              ║
                ║Preco do Produto : {item.Preco}                ║
                ║Marca do Produto(Codigo) : {item.Marca.Codigo} ║
                ╚═══════════════════════════════════════════════╝");
            }

            return listProduto;
        }
        public void Deletar()
        {
            Console.WriteLine($"Informe o Nome do Produto que deseja excluir :");
            string produtoExcluir = Console.ReadLine().ToUpper();

            Produto produtoBuscado = listProduto.Find(CadaUsuario => CadaUsuario.NomeProduto == produtoExcluir);

            listProduto.Remove(produtoBuscado);
        }
    }

}