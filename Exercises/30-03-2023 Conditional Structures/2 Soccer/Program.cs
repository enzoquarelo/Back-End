//Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

Console.WriteLine($"Informe o nome do primeiro time:");
string equipe1 = Console.ReadLine();

Console.WriteLine($"Informe o nome do segundo time:");
string equipe2 = Console.ReadLine();

Console.WriteLine($"Informe a puntuação do {equipe1}:");
int time1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe a pontuação do {equipe2}:");
int time2 = int.Parse(Console.ReadLine());

if(time1 > time2)
{
 Console.WriteLine($"O {equipe1} foi a vitóriosa, e o time {equipe2} ficou em segundo lugar.");
}

else if(time2 > time1)
{
 Console.WriteLine($"O {equipe2} foi a vitóriosa, e o time {equipe1} ficou em segundo lugar.");
}

else if(time1 == time2)
{
 Console.WriteLine($"O jogo acabou com um empate entre os times {equipe1} e {equipe2}.");
}

