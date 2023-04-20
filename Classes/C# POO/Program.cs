using C__POO;

Personagem Personagem1 = new Personagem();

Console.WriteLine($"Informe o nome do seu campeao :");
Personagem1.nome = Console.ReadLine();
Console.WriteLine($"Informe a idade de {Personagem1.nome} :");
Personagem1.idade = int.Parse(Console.ReadLine());
Console.WriteLine($"O {Personagem1.nome} tera armadura ? Se sim informe o nome de sua armadura:");
Personagem1.armadura = Console.ReadLine();
Console.WriteLine($"Informe a ia (inteligencia artificial) utilizada pelo {Personagem1.nome}:");
Personagem1.ia = Console.ReadLine();


Console.WriteLine($"Confira as informacoes do seu campeao");
Console.WriteLine(@$"
Nome : {Personagem1.nome}
Idade : {Personagem1.idade}
Armadura : {Personagem1.armadura}
I.A : {Personagem1.ia}");

static void Loading(string texto, int pontos, int tempo)
{
    Console.Write(texto);

    for(var i = 0; i < pontos; i++)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($".");
        Thread.Sleep(tempo);
    }
    
    Console.ResetColor();
}

Loading("Carregando", 6, 1000);

Console.WriteLine($"Ola {Personagem1.nome}, bem-vindo a nossa equipe, voce foi convocada para o Resgate do Calice de Daenerys, nossa rainha");

Console.WriteLine($"O vilao que vc deve enfrentar para o resgate se encontra na estacao de trem de Maua");

static void LoadingTerreno(string texto, int pontos, int tempo)
{
    Console.Write(texto);

    for(var i = 0; i < pontos; i++)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($".");
        Thread.Sleep(tempo);
    }
    
    Console.ResetColor();
}

Loading("Carregando Terreno", 3, 1000);

Console.WriteLine($"Voce chegou ao destino, esta pronto para a batalha? s/n");
char respostaBatalha = char.Parse(Console.ReadLine().ToLower());

switch(respostaBatalha)
{
    case 's':
        Console.WriteLine($"Vamos para o comfronto {Personagem1.nome}, o vilao que voce ira lutar e conhecido como Figma, o terror de todos os devs.");
    break;

    case 'n':
        Console.WriteLine($"Voce e um covarde (Andre), voce nao faz mais parte da nossa equipe .");
    break;
}

Console.WriteLine($"{Personagem1.nome} para auxiliar em seu confronto vc tera as seguintes acoes :");








