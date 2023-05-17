namespace ProjetoCadastro_16_05
{
    public class Marca
    {
        private int Codigo { get; set; }
        private string NomeMarca { get; set; }

        private DateTime DataCadastro { get; set; }
        public Marca(string nomeMarca, int codigo, DateTime dataCadastro)
        {
            NomeMarca = nomeMarca;
            Codigo = codigo;
            DataCadastro = dataCadastro;
        }

        List<Marca> listMarca = new List<Marca>();
        public string Cadastrar(string novaMarca)
        {
            Console.WriteLine($"Vamos realizar o cadastro da sua Marca :");
            Console.Write($"Informe o nome da marca:");
            NomeMarca = Console.ReadLine();
            Console.Write($"Informe o codigo da marca:");
            Codigo = int.Parse(Console.ReadLine());
            DataCadastro = DateTime.Now;

            listMarca.Add(new Marca(NomeMarca, Codigo, DataCadastro));

            return novaMarca;
        }
        public List<Marca> Listar(List<Marca> listagem)
        {
            foreach (var item in listMarca)
            {
                Console.WriteLine(@$"
                Codigo : {item.NomeMarca}
                Nome do Produto : {item.Codigo}
                Preco do Produto : {item.DataCadastro}");
            }

            return listagem;
        }
        public void Deletar()
        {
            Console.WriteLine($"Informe o Nome da Marca que deseja excluir :");
            string marcaExcluir = Console.ReadLine();

            int indice = listMarca.FindIndex(CadaUsuario => CadaUsuario.NomeMarca == marcaExcluir);
            if (indice != -1)
            {
                listMarca.RemoveAt(indice);
                indice++;
                listMarca.RemoveAt(indice);
                indice++;
                listMarca.RemoveAt(indice);

            }
            else
            {
                Console.WriteLine("Esse email nao foi cadastrado. Tente Novamente!");
                marcaExcluir = Console.ReadLine();
            }

        }
    }
}