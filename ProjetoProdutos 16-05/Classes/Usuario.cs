namespace ProjetoCadastro_16_05.Classes
{
    public class Usuario
    {
        
        private int Codigo { get; set; }
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }
        private DateTime DataCadastro { get; set; }
        List<Usuario> listUsuario = new List<Usuario>();

        public Usuario(string email, string senha, string nome, DateTime dataCadastro)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            DataCadastro = dataCadastro;
        }

        public string Cadastrar(string novoUsuario)
        {
            Console.WriteLine($"Vamos realizar seu cadastro :");
            Console.Write("Nome Completo: ");
            Nome = Console.ReadLine();
            Console.Write("Email: ");
            Email = Console.ReadLine();
            Console.Write("Senha: ");
            Senha = Console.ReadLine();
            DataCadastro = DateTime.Now;

            listUsuario.Add(new Usuario(Email, Senha, Nome, DataCadastro));

            return novoUsuario;
        }
        public void Deletar()
        {
            Console.WriteLine($"Informe o email do usuario que deseja excluir :");
            string usuarioExcluir = Console.ReadLine();

            int indice = listUsuario.FindIndex(CadaUsuario => CadaUsuario.Email == usuarioExcluir);
            if (indice != -1)
            {
                listUsuario.RemoveAt(indice);
                indice++;
                listUsuario.RemoveAt(indice);
                indice++;
                listUsuario.RemoveAt(indice);
                indice++;
                listUsuario.RemoveAt(indice);
            }
            else
            {
                Console.WriteLine("Esse email nao foi cadastrado. Tente Novamente!");
                usuarioExcluir = Console.ReadLine();
            }

        }


    }
}
