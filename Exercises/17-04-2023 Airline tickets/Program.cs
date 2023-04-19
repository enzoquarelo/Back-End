// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

//Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
//O sistema deve exibir um menu com as seguintes opções:

//1- Cadastrar passagem
//2- Listar Passagens
//0- Sair

string[] usuario = new string[2];
string[] origem = new string[2];
string[] destino = new string[2];
string[] datas = new string[2]; //data = "dd/mm/aaaa"


static bool fazerLogin(int senha)
{
    if (senha != 123456)
    {
        Console.WriteLine($"Senha incorreta!");
        return false;
    }
    else
    {
        return true;
    }
}


Console.WriteLine(@$"
 _________________________________
|                                 |
| Bem-vindos a Agencia de Viagens |
|_________________________________|
");

bool tentativaSenha;

//validação de senha
do
{
    Console.WriteLine($"Informe a senha padrão: ");
    int senha = int.Parse(Console.ReadLine());

    tentativaSenha = fazerLogin(senha);

} while (tentativaSenha == false);


string escolhaMenu;

do
{
    //menu de opções
Console.WriteLine($"**Menu inicial**");
Console.WriteLine($"Selecione uma opção:");
Console.WriteLine($"[1] - Cadastro");
Console.WriteLine($"[2] - Listar");
Console.WriteLine($"[0] - Sair");

escolhaMenu = Console.ReadLine();

switch (escolhaMenu)
{
    case "1":

        string resposta;

        do
        {
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine($"Informe o nome: ");
                usuario[i] = Console.ReadLine();

                Console.WriteLine($"Informe a origem: ");
                origem[i] = Console.ReadLine();

                Console.WriteLine($"Informe o destino: ");
                destino[i] = Console.ReadLine();

                Console.WriteLine($"Informe a data: ");
                datas[i] = Console.ReadLine();
            }

            Console.WriteLine($"Gostaria de cadastrar uma nova passagem ? s/n");
            resposta = Console.ReadLine().ToLower();

        } while (resposta == "s");
        break;
    case "2":
        for (var i = 0; i < 2; i++)
        {
            Console.WriteLine(@$"
            -------------------
            Bilhete de Passagem

            Nome: {usuario[i]}
            Origem: {origem[i]}
            Destino: {destino[i]}
            Data: {datas[i]}            
            ");
        }
        break;
    case "0":
        Console.WriteLine($"Fim");
        break;
    default:
        Console.WriteLine($"Opção inválida");
        break;
}
} while (escolhaMenu != "0");