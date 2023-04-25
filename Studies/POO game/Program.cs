using POO_game;

PokemonInicial Inicial= new PokemonInicial();

static void MenuCombate(string menuResposta) 
{
  Console.WriteLine(@$"
-----------Menu de Combate---------
   | Ataques |            | Bolsa |
| Trocar Pokemon |        | Fugir |");
Console.WriteLine($"Digite o nome da aba que deseja acessar .");
menuResposta = Console.ReadLine().ToLower();
}

Console.WriteLine($"Ola viajante, como podemos te chamar?");
Inicial.Nome = Console.ReadLine();
Console.WriteLine($"Muito bem {Inicial.Nome}, quantos anos voce tem?");
Inicial.Idade = Console.ReadLine();


Console.WriteLine(@$"
 _______________________________________________________________________________
|    Bem-Vindo ao mundo de Pokemon! Obrigado por utilizar nosso codigo.         |
|Agora, por-favor escolha uma geracao desejada para ir a escolha de seu inicial |
|                                                                               |
|1- Geracao de Kanto       4- Geracao de Sinnoh        7- Geracao de Alola      |
|2- Geracao de Johto       5- Geracao de Unova         8- Geracao de Galar      |
|3- Geracao de Hoenn       6- Geracao de Kalos         9- Geracao de Paldea     |
|_______________________________________________________________________________|");
Console.WriteLine($"");


Inicial.EscolhaGeracao =char.Parse(Console.ReadLine());

switch(Inicial.EscolhaGeracao)
{
    case '1':
    Console.WriteLine(@$"
     ______________________________________________________________
    |Agora, por-favor escolha o seu inicial da geracao escolhida : |
    |       1) Charmander    2) Bulbasaur    3)Squirtle            |
    |______________________________________________________________|");
    Inicial.EscolhaInicial = char.Parse(Console.ReadLine());
    break;
    case '2':
    Console.WriteLine(@$"
     ______________________________________________________________
    |Agora, por-favor escolha o seu inicial da geracao escolhida : |
    |       1) Cyndaquil    2) Chikorita    3)Totodile             |
    |______________________________________________________________|");
    Inicial.EscolhaInicial = char.Parse(Console.ReadLine());
    break;
    case '3':
    Console.WriteLine(@$"
     ______________________________________________________________
    |Agora, por-favor escolha o seu inicial da geracao escolhida : |
    |          1) Torchic    2) Treecko    3)Mudkip                |
    |______________________________________________________________|");
    Inicial.EscolhaInicial = char.Parse(Console.ReadLine());
    break;
    case '4':
    Console.WriteLine(@$"
     ______________________________________________________________
    |Agora, por-favor escolha o seu inicial da geracao escolhida : |
    |          1) Chimchar    2) Turtwig    3)Piplup               |
    |______________________________________________________________|");
    Inicial.EscolhaInicial = char.Parse(Console.ReadLine());
    break;
    case '5':
    Console.WriteLine(@$"
     ______________________________________________________________
    |Agora, por-favor escolha o seu inicial da geracao escolhida : |
    |            1) Tepig.    2) Snivy    3) Oshawott              |
    |______________________________________________________________|");
    Inicial.EscolhaInicial = char.Parse(Console.ReadLine());
    break;
    case '6':
    Console.WriteLine(@$"
     ______________________________________________________________
    |Agora, por-favor escolha o seu inicial da geracao escolhida : |
    |         1) Fennekin     2) Chespin    3)Froakie              |
    |______________________________________________________________|");
    Inicial.EscolhaInicial = char.Parse(Console.ReadLine());
    break;
    case '7':
    Console.WriteLine(@$"
     ______________________________________________________________
    |Agora, por-favor escolha o seu inicial da geracao escolhida : |
    |          1) Litten    2)  Rowlett    3)Popplio               |
    |______________________________________________________________|");
    Inicial.EscolhaInicial = char.Parse(Console.ReadLine());
    break;
    case '8':
    Console.WriteLine(@$"
     ______________________________________________________________
    |Agora, por-favor escolha o seu inicial da geracao escolhida : |
    |         1) Scorbunny    2) Grookey    3) Sobble              |
    |______________________________________________________________|");
    Inicial.EscolhaInicial = char.Parse(Console.ReadLine());
    break;
    case '9':
    Console.WriteLine(@$"
     ______________________________________________________________
    |Agora, por-favor escolha o seu inicial da geracao escolhida : |
    |         1) Fuecoco    2) Sprigatito    3)Quaxly              |
    |______________________________________________________________|");
    Inicial.EscolhaInicial = char.Parse(Console.ReadLine());
    break;
    
}

switch (Inicial.EscolhaInicial)
{
    case '1':
    Console.WriteLine($"Meus parabens, eu sou o Professor Carvalho. Eu estou aqui para orientalo logo preciso te dizer que outros treinadores pokemons estao na mesma jornada que a sua, entao escolha bem seus adversarios, seu pokemon e do tipo fogo, evite lutar contra tipos agua");
    break;
    case '2':
    Console.WriteLine($"Meus parabens, eu sou o Professor Carvalho. Eu estou aqui para orientalo logo preciso te dizer que outros treinadores pokemons estao na mesma jornada que a sua, entao escolha bem seus adversarios, seu pokemon e do tipo plata, evite lutar contra tipos fogo");
    break;
    case '3':
    Console.WriteLine($"Meus parabens, eu sou o Professor Carvalho. Eu estou aqui para orientalo logo preciso te dizer que outros treinadores pokemons estao na mesma jornada que a sua, entao escolha bem seus adversarios, seu pokemon e do tipo agua, evite lutar contra tipos planta");
    break;
    
}
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Precione <Enter> para prosseguirmos !");
Console.ResetColor();
Console.ReadLine();

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(@$"
Steven - HAHAHAHAHAHA, mas voce so pode ser um idiota mesmo, voce escolheu o pior de todos os pokemons, tenho certeza que consigo te derrotar em segundos...");
Console.ResetColor();
Console.WriteLine($"");

Console.WriteLine($"{Inicial.Nome} voce quer batalhar com Steven? s/n");
char respostaBatalha = char.Parse(Console.ReadLine().ToLower());

switch (respostaBatalha)
{
    case 's':
        static void LoadingBatalha(string texto, int pontos, int tempo)
{
        Console.Write(texto);

        for(var i = 0; i < pontos; i++)
        {
        Console.Write($".");
        Thread.Sleep(tempo);
        }
    
    Console.ResetColor();
}
LoadingBatalha("Carregando Batalha", 3, 1000);
        break;
    case 'n':
        Console.WriteLine($"Eu sabia que voce era um covarde, como voce quer ser um treinador pokemon assim?");
        Console.WriteLine($"{Inicial.Nome} voce quer batalhar com Steven? s/n");
        respostaBatalha = char.Parse(Console.ReadLine().ToLower());

        break;
    default:
    Console.WriteLine($"Insira uma resposta valida, sendo S para sim e N para nao");
    
        break;
}

if (Inicial.EscolhaInicial == 1)
{
    Inicial.PokemonSteven = "Squirtle";
}
else if (Inicial.EscolhaInicial == 2)
{
    Inicial.PokemonSteven = "Charmander";
}
if (Inicial.EscolhaInicial == 3)
{
    Inicial.PokemonSteven = "Bulbasaur";
}

Console.WriteLine($"Steven lancou {Inicial.PokemonSteven}");

















