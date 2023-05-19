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
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(@$"
            ┌──────────────────────────────────────────┐
            |Bem-Vindo ao nosso Programa de Produtos   |
            |[1] Fazer Login                           |
            |[2] Cadastrar                             |
            └──────────────────────────────────────────┘");
                Console.ResetColor();
                opcaoCadastro = char.Parse(Console.ReadLine());

                switch (opcaoCadastro)
                {
                    case '1':
                        if (usuario.Email == null || usuario.Senha == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Nao ha nenhum usuario cadastrado no programa, faca seu cadastro.");
                            Console.ResetColor();
                            usuario.Cadastrar();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"Insira seu email: ");
                            Console.ResetColor();
                            string email = Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"Insira sua senha: ");
                            Console.ResetColor();
                            string senha = Console.ReadLine();

                            if (email == usuario.Email && senha == usuario.Senha)
                            {
                                this.Logado = true;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Login efetuado com sucesso !");
                                Console.ResetColor();
                            }
                            else
                            {
                                this.Logado = false;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Falha ao logar !");
                                Console.ResetColor();
                            }
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
                ║         Menu         ║
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