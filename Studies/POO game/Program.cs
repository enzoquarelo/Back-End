using POO_game;

Console.WriteLine(@$"
 _______________________________________________________________________________
|    Bem-Vindo ao mundo de Pokemon! Obrigado por utilizar nosso codigo.         |
|Agora, por-favor escolha uma geracao desejada para ir a escolha de seu inicial |
|                                                                               |
|1- Geracao de Kanto       4- Geracao de Sinnoh        7- Geracao de Alola      |
|2- Geracao de Johto       5- Geracao de Unova         8- Geracao de Galar      |
|3- Geracao de Hoenn       6- Geracao de Kalos         9- Geracao de Paldea     |
|_______________________________________________________________________________|");

char escolhaGeracao =char.Parse(Console.ReadLine());

switch(escolhaGeracao)
{
    case '1':
    Console.WriteLine(@$"
    Agora, por-favor escolha o seu inicial da geracao escolhida :
    ");
    
    break;
}



