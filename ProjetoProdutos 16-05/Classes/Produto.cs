namespace ProjetoCadastro_16_05.Classes
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Marca Marca { get; private set; }
        public Usuario Usuario { get; private set; }
        public Usuario CadastradoPor { get; private set; }
        public List<Produto> ListaDeProdutos { get; private set; }
        Usuario ObjetoUsuario = new Usuario();
        public Produto()
        {}
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

        public void Cadastrar()
        {
            Console.WriteLine($"Vamos realizar o cadastro do Produto :");
            Console.Write($"Informe o codigo do Produto:");
            Codigo = int.Parse(Console.ReadLine());
            Console.Write($"Informe o nome do Produto:");
            NomeProduto = Console.ReadLine().ToUpper();
            Console.Write($"Informe o preco do Produto:");
            Preco = float.Parse(Console.ReadLine());
            Console.Write($"Informe o codigo da marca do Produto:");
            int codigoMarca = int.Parse(Console.ReadLine());
            Marca.procurarMarca(codigoMarca);
            ObjetoUsuario.Email = CadastradoPor.Email;
            DataCadastro = DateTime.Now;

            listProduto.Add(new Produto(NomeProduto , Preco, Marca, CadastradoPor, DataCadastro, Codigo));
        }
        public List<Produto> Listar()
        {
            foreach (var item in ListaDeProdutos)
            {
                Console.WriteLine(@$"
                ╔══════════════════════════════════════════╗
                ║Nome do Produto : {item.NomeProduto}      ║  
                ║Codigo do Produto : {item.Codigo}         ║
                ║Preco do Produto : {item.Preco}           ║
                ║Marca do Produto(Codigo) : {item.Marca}   ║
                ║Cadastrado por : {item.CadastradoPor}     ║
                ║Data do Cadastro : {item.DataCadastro}    ║
                ╚══════════════════════════════════════════╝");
            }
           return ListaDeProdutos; 
        }
        public void Deletar()
        {
            Console.WriteLine($"Informe o Nome do Produto que deseja excluir :");
            string produtoExcluir = Console.ReadLine().ToUpper();

            int indice = listProduto.FindIndex(CadaUsuario => CadaUsuario.NomeProduto == produtoExcluir);
            if (indice != -1)
            {
                listProduto.RemoveAt(indice);
                indice++;
                listProduto.RemoveAt(indice);
                indice++;
                listProduto.RemoveAt(indice);
                indice++;
                listProduto.RemoveAt(indice);
                indice++;
                listProduto.RemoveAt(indice);
                indice++;
                listProduto.RemoveAt(indice);

            }
            else
            {
                Console.WriteLine("Essa marca nao foi cadastrada. Tente Novamente!");
                produtoExcluir = Console.ReadLine();
            }
        }
    }

}