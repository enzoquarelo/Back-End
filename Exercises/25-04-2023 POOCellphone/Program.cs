using _25_04_2023_POOCellphone;

Celular celular = new Celular();

celular.Cor = "Preto";
celular.Modelo = "Samsung Galaxy";
celular.Tamanho = 5.5;

string ligarResposta;


Console.WriteLine($"Voce deseja ligar seu despositivo ? s/n");
ligarResposta = Console.ReadLine().ToLower();
if(ligarResposta == "s")
{
    celular.Ligar();
    celular.MenuCelular();

    do
    {
        if(celular.escolhaMenu == "1")
    {
        celular.FazerLigacao();
        celular.MenuCelular();
    }
    else if(celular.escolhaMenu == "2")
    {
        celular.EnviarMensagem();
        celular.MenuCelular();
    }
    else if(celular.escolhaMenu == "3")
    {
        celular.Desligar();
    }
    } while (celular.escolhaMenu != "3");
    
}
else if (ligarResposta == "n")
{
    celular.Desligar();
}
else
{
    Console.WriteLine($"Caracter invalido, digite s para sim ou n para nao deseja ligar o seu dispositivo.");
    ligarResposta = Console.ReadLine().ToLower();
}

