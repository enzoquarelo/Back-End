namespace ProjetoCadastro_16_05.Classes
{
    public class Usuario
    {
        
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public Usuario()
        {

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

            return novoUsuario;
        }
        public void Deletar()
        {
            Console.WriteLine($"Informe o email do usuario que deseja excluir :");
            string usuarioExcluir = Console.ReadLine();

            
            if (usuarioExcluir == Email)
            {
                Nome = "";
                Email = "";
                Senha = "";
            }
            else
            {
                Console.WriteLine("Esse email nao foi cadastrado. Tente Novamente!");
                usuarioExcluir = Console.ReadLine();
            }

        }


    }
}
