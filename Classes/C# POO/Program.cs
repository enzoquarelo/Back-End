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

Personagem1.Atacar();
Personagem1.RestaurarArmadura();
Console.WriteLine(Personagem1.Defender());



