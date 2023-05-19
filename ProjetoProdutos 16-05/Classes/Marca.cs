namespace ProjetoCadastro_16_05
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }

        public DateTime DataCadastro { get; set; }

        public Marca()
        { }
        public Marca(string nomeMarca, int codigo, DateTime dataCadastro)
        {
            NomeMarca = nomeMarca;
            Codigo = codigo;
            DataCadastro = dataCadastro;
        }

        public static List<Marca> listMarca = new List<Marca>();
        public Marca Cadastrar()
        {
            Marca novaMarca = new Marca();

            DataCadastro = DateTime.Now;
            Console.Write($"Informe o codigo da marca:");
            int codigo = int.Parse(Console.ReadLine());

            novaMarca = listMarca.Find(x => x.Codigo == codigo);

            if (novaMarca == null)
            {
                novaMarca = new Marca();
                novaMarca.Codigo = codigo;
                Console.Write($"Informe o nome da marca:");
                novaMarca.NomeMarca = Console.ReadLine().ToUpper();

                listMarca.Add(novaMarca);
                return novaMarca;
            }
            else
            {
                Console.WriteLine($"A marca ja existe! *{novaMarca.NomeMarca}*");
                return novaMarca;
            }
        }

        public List<Marca> Listar()
        {
            foreach (var item in listMarca)
            {
                Console.WriteLine(@$"
                Nome da Marca : {item.NomeMarca}
                Codigo : {item.Codigo}
                Data de cadastro : {item.DataCadastro}");
            }

            return listMarca;
        }
        public void Deletar()
        {
            Console.WriteLine($"Informe o Nome da Marca que deseja excluir :");
            string marcaExcluir = Console.ReadLine().ToUpper();

            Marca marcaBuscada = listMarca.Find(CadaUsuario => CadaUsuario.NomeMarca == marcaExcluir);

            listMarca.Remove(marcaBuscada);
        }
    }
}