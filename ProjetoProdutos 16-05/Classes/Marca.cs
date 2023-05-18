namespace ProjetoCadastro_16_05
{
    public class Marca
    {
        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }

        public DateTime DataCadastro { get; private set; }
        public Marca()
        {}
        public Marca(string nomeMarca, int codigo, DateTime dataCadastro)
        {
            NomeMarca = nomeMarca;
            Codigo = codigo;
            DataCadastro = dataCadastro;
        }

        List<Marca> listMarca = new List<Marca>();
        public void Cadastrar()
        {
            Console.WriteLine($"Vamos realizar o cadastro da sua Marca :");
            Console.Write($"Informe o nome da marca:");
            NomeMarca = Console.ReadLine();
            Console.Write($"Informe o codigo da marca:");
            Codigo = int.Parse(Console.ReadLine());
            DataCadastro = DateTime.Now;

            listMarca.Add(new Marca(NomeMarca, Codigo, DataCadastro));
        }
        public void procurarMarca(int codigo)
        {
            Marca marca = listMarca.Find(x => x.Codigo == codigo);
            if (marca == null)
            {
                Console.WriteLine($"Nao ha nenhuma marca cadastrada com o codigo digitado...");
                Cadastrar();
            }
            else
            {
                
            }
        }

        public List<Marca> Listar(List<Marca> listagem)
        {
            foreach (var item in listMarca)
            {
                Console.WriteLine(@$"
                Codigo : {item.NomeMarca}
                Nome da Marca : {item.Codigo}
                Data de cadastro : {item.DataCadastro}");
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
                Console.WriteLine("Essa marca nao foi cadastrada. Tente Novamente!");
                marcaExcluir = Console.ReadLine();
            }

        }
    }
}