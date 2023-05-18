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
        public Produto(int codigo, string nomeProduto, float preco, Marca marca, Usuario cadastradoPor, DateTime dataCadastro)
        {
            Codigo = codigo;
            NomeProduto = nomeProduto;
            Preco = preco;
            Marca = marca;
            CadastradoPor = cadastradoPor;
            DataCadastro = dataCadastro;
        }

        List<Produto> listProduto = new List<Produto>();

        public string Cadastrar(string novoProduto)
        {
            Console.WriteLine($"Vamos realizar o cadastro do Produto :");
            Console.Write($"Informe o codigo do Produto:");
            Codigo = int.Parse(Console.ReadLine());
            Console.Write($"Informe o nome do Produto:");
            NomeProduto = Console.ReadLine();
            Console.Write($"Informe o preco do Produto:");
            Preco = float.Parse(Console.ReadLine());
            Console.Write($"Informe o codigo da marca do Produto:");
            int codigoMarca = int.Parse(Console.ReadLine());
            Marca.procurarMarca(codigoMarca);
            ObjetoUsuario.Email = CadastradoPor.Email;
            DataCadastro = DateTime.Now;

            listProduto.Add(new Produto(Codigo, NomeProduto , Preco, Marca, CadastradoPor, DataCadastro));

            return novoProduto;
        }
        public List<Produto> Listar()
        {
            foreach (var item in ListaDeProdutos)
            {
                
            }
           return ListaDeProdutos; 
        }
        public void Deletar()
        {

        }
    }

}