using Elevator;

Elevador UsarElevador = new Elevador();

do
{
    UsarElevador.MenuElevador();
    switch (UsarElevador.OpcaoMenu)
{
    case '1':
        UsarElevador.Subir();
        break;
    case '2':
        UsarElevador.Descer();
        break;
    case '3':
        UsarElevador.Sair();
        break;
    default:
    Console.WriteLine($"Escolha um opcao valida, Tente Novamente !");
        break;
}
} while (UsarElevador.SairElevador != 1);