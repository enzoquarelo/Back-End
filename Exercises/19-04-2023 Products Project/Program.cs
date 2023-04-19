// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

//Os produtos terão os seguintes atributos:
//string Nome
//float Preco
//bool Promocao (se está em promoção ou não)

//O sistema deverá ter as seguintes funcionalidades:
//CadastrarProduto
//ListarProdutos
//MostrarMenu

//declarar variaveis
string[] nomeProduto = new string[3];
float[] precoProduto = new float[3];
float[] promocaoProduto = new float[3];
char escolhaMenu;


Console.WriteLine(@$"Bem-vindo ao nosso programa de gerenciamento de estoque !");

Console.WriteLine(@$"");

do
{
    Console.WriteLine(@$"
 ______________________
|    Menu de Escolha   |
|                      |
|1- Cadastrar produto  |
|2- Listar produtos    |
|3- Sair               |
|______________________|
");
    escolhaMenu = char.Parse(Console.ReadLine());

    switch (escolhaMenu)
    {
        case '1':

            string respostaPromocao;

            for (var i = 1; i < 3; i++)
            {
                Console.WriteLine($"Informe o nome do produto: ");
                nomeProduto[i] = Console.ReadLine();

                Console.WriteLine($"Informe o preco do seu produto: ");
                precoProduto[i] = float.Parse(Console.ReadLine());

                Console.WriteLine($"Seu produto cadastrado esta em promocao ? s/n");
                respostaPromocao = Console.ReadLine().ToLower();

                if (respostaPromocao == "s")
                {
                    Console.WriteLine($"Informe a promocao do produto em: (R$): ");
                    promocaoProduto[i] = float.Parse(Console.ReadLine());
                }

            }
            break;

        case '2':
            for (var i = 1; i < 3; i++)
            {
                if (promocaoProduto[i] != 0)
                {
                    Console.WriteLine(@$"");
                    
                    Console.WriteLine(@$"Informacoes do produto {i}:
Produto: {nomeProduto[i]}
Preco: {precoProduto[i]}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($@"
*ESTE PRODUTO ESTA EM PROMOCAO*
Seu preco sera de : {precoProduto[i] - promocaoProduto[i],2}
                     ");
                    Console.ResetColor();

                }
                else if (promocaoProduto[i] == 0)
                {
                    Console.WriteLine(@$"Informacoes do produto {i}:
Produto: {nomeProduto[i]}
Preco: {precoProduto[i]}");
                }
            }
            break;
        case '3':
            Console.WriteLine($"Fim do programa");
            break;
        default:
            Console.WriteLine($"Opção inválida");
            break;
    }
} while (escolhaMenu != '3');