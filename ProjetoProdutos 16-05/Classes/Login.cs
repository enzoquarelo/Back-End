namespace ProjetoCadastro_16_05.Classes
{
    public class Login
    {
        public bool Logado { get; private set; }

        public Login()
        {
            Usuario user = new Usuario();
            Logar(user);
        }

        public void Logar(Usuario usuario)
        {
            Usuario usuario1 = new Usuario();
            char opcaoCadastro;

            do
            {
                Console.WriteLine(@$"
            Bem-Vindo ao nosso Programa de Produtos
            [1] Fazer Login
            [2] Cadastrar");
                opcaoCadastro = char.Parse(Console.ReadLine());

                switch (opcaoCadastro)
                {
                    case '1':
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
                        if (Logado == true)
                        {
                            GerarMenu();
                        }

                        break;
                    case '2':
                        usuario.Cadastrar();
                        break;
                    default:
                        Console.WriteLine($"Opcao invalida, Tente Novamente !");
                        opcaoCadastro = char.Parse(Console.ReadLine());
                        break;
                }
            } while (opcaoCadastro != 1);
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
                        marca.Cadastrar();
                        break;
                    case '2':
                        marca.Listar();
                        break;
                    case '3':
                        marca.Deletar();
                        break;
                    case '4':
                        produto.Cadastrar();
                        break;
                    case '5':
                        produto.Listar();
                        break;
                    case '6':
                        produto.Deletar();
                        break;

                    default:
                        Console.WriteLine($"Opcao invalida, Tente Novamente !");
                        opcaoMenu = char.Parse(Console.ReadLine());
                        break;
                }


            } while (true);
        }

    }
}