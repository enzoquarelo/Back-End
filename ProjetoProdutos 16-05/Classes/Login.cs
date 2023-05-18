namespace ProjetoCadastro_16_05.Classes
{
    public class Login
    {
        public bool Logado { get; private set; }

        public Login()
        {       
            Usuario user = new Usuario();
            Logar(user);

            if (Logado == true)
            {
                GerarMenu();
            }
        }

        public void Logar(Usuario usuario)
        {
            Console.WriteLine($"Insira seu email: ");
            string email = Console.ReadLine();

            Console.WriteLine($"Insira sua senha: ");
            string senha = Console.ReadLine();

            if (email == usuario.Email && senha == usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login efetuado com sucesso !");
            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha ao logar !");
            }
        }

        public void Deslogar()
        {
            Logado = false;
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            char opcaoMenu;

            do
            {
                Console.WriteLine(@$"
                ╔══════════════════════╗
                ║        Menu          ║
                ╠══════════════════════╣
                ║[1] Cadastrar Marca   ║
                ║[2] Listar Marcas     ║
                ║[3] Remover Marca     ║
                ╠══════════════════════╣
                ║[4] Cadastrar Produto ║
                ║[5] Listar Produtos   ║
                ║[6] Remover Produto   ║
                ╚══════════════════════╝");
                opcaoMenu = char.Parse(Console.ReadLine());
                
                switch (opcaoMenu)
                {
                    case '1':
                    break;
                    case '2':
                    break;
                    case '3':
                    break;
                    case '4':
                    break;
                    case '5':
                    break;
                    case '6':
                    break;

                    default:
                    break;
                }
                

            }while(true);
        }

    }
}