namespace ProjetoCadastro_16_05.Classes
{
    public class Usuario
    {
        
        public string Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        List<Usuario> listUsuario = new List<Usuario>();
        
        public Usuario()
        {}
        public Usuario(string email, string senha, string nome, DateTime dataCadastro)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            DataCadastro = dataCadastro;
        }

        public void Cadastrar()
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
        }
        public void Deletar()
        {
            Console.WriteLine($"Informe o email do usuario que deseja excluir :");
            string usuarioExcluir = Console.ReadLine();

            Usuario usuarioBuscado = listUsuario.Find(CadaUsuario => CadaUsuario.Email == usuarioExcluir);

            listUsuario.Remove(usuarioBuscado);
        }


    }
}
