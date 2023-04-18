// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

//Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
//O sistema deve exibir um menu com as seguintes opções:

//1- Cadastrar passagem
//2- Listar Passagens
//0- Sair

string usuario = "";
string origem = "";
string destino = "";
string dataPartida = "";
string dataFinal = "";

static void menu()
{
    Console.WriteLine(@$"
 ________________________________
|   Menu da Agencia de Turismo   |
|                                |
|1- Cadastrar passagem           |
|2- Listar Passagens             |
|3- Sair                         |
|________________________________|
");
}

static void listagemViagens(string usuario, string origem, string destino, string dataPartida, string dataFinal)
{
    for (int exibir = 1; exibir <=  3; exibir++)
    {
        Console.WriteLine($"Sera exibido a seguir as informacoes sobre as viagens cadastradas de cada usuario");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{exibir}° Usuario:");
        Console.ResetColor();
        Console.WriteLine($"{usuario}");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"Origem da viagem:");
        Console.ResetColor();
        Console.WriteLine($"{origem}");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"Destino da viagem:");
        Console.ResetColor();
        Console.WriteLine($"{destino}");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"Dastas cadastradas para a viagem:");
        Console.ResetColor();
        Console.WriteLine($"Data de Partida : {dataPartida} e Data de fim da viagem :{dataFinal}");
    }
}

int senha = 123456;

Console.WriteLine(@$"
 ________________________________
|    Bem-Vindo a nossa Agencia   |
|                                |
| Por-favor informe a senha para |
|      que possamos seguir!      |
|________________________________|
");

int tentativaSenha = int.Parse(Console.ReadLine());

if (tentativaSenha == senha)
{
    Console.WriteLine($"Senha válidada, pressione <Enter> para seguir.");
}
else
{
    Console.WriteLine($"Senha Incorreta, tente novamente. !");
    tentativaSenha = int.Parse(Console.ReadLine());
}

menu();
char opcaoMenu = char.Parse(Console.ReadLine());

while(true)
{
  switch (opcaoMenu)
{

    case '1':
        {
            for (int i = 1; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Informe o Nome do {i}° Passageiro :");
                Console.ResetColor();
                usuario = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Informe a origem da viagem : ");
                Console.ResetColor();
                origem = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Informe o destino de sua viagem :");
                Console.ResetColor();
                destino = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Informe a data de partida da viagem:(dia/mes/ano)");
                Console.ResetColor();
                dataPartida = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Informe a data de termino da viagem:(dia/mes/ano)");
                Console.ResetColor();
                dataFinal = Console.ReadLine();
            }

           menu(); 
           opcaoMenu = char.Parse(Console.ReadLine());

        }
        break;
    case '2':

        listagemViagens(usuario, origem, destino, dataPartida, dataFinal);

        break;
    case '3':

        break;
    default:
        Console.WriteLine($"Por-favor, informe uma opcao valida do menu :");

        break;
}
}