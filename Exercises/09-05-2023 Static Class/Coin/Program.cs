//Exercício : Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
//Menu de opções : dólar para real, real para dólar, sair
//Personalizar a resposta, usando recursos da linguagem(Bibliotecas)

using Coin;

static void Menu()
{
    Console.WriteLine(@$"
 ______________________________
|             Menu             |
|------------------------------|
|[1] Converter Dolar para Real |
|[2] Converter Real para Dolar |
|[3] Sair                      |
|______________________________|");

}

Console.WriteLine($"Bem-vindo ao nosso programa $$$!");

Menu();
char respostaMenu = char.Parse(Console.ReadLine());

do
{
    switch (respostaMenu)
    {
        case '1':
            Cambio.DolarParaReal();
            Menu();
            respostaMenu = char.Parse(Console.ReadLine());
            break;

        case '2':
            Cambio.RealParaDolar();
            Menu();
            respostaMenu = char.Parse(Console.ReadLine());
            break;

        case '3':
            Console.WriteLine($"Programa Encerrado!");
            break;

        default:
            Console.WriteLine($"Opcao invalida! Tente Novamete.");
            Menu();
            respostaMenu = char.Parse(Console.ReadLine());
            break;
    }

} while (respostaMenu == 3);