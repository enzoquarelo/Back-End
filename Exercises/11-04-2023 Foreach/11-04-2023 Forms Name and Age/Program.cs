// Exercicio de Fixacao
//escreva um programa que receba e imprima o nome e a idade de 5 pessoas
//personalizar core: a resposta do nome em azul e a resposta da idade em verde (cor da fonte)

string[] nomes = new string[5];
int[] idade = new int[5];

Console.WriteLine($"Neste programa, digite o nome e idade de 5 pessoas.");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o nome da {i + 1}º pessoa!");
    nomes[i] = Console.ReadLine();

    Console.WriteLine($"Digite a idade da {i + 1}º pessoa!");
    idade[i] = int.Parse(Console.ReadLine());
}

for (int posicao = 0; posicao < 5; posicao++)
{
    Console.Write(@$"{posicao + 1}) ");

    Console.Write($"Nome: ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{nomes[posicao]}");
    

    Console.ResetColor();
    Console.Write($"   Idade: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{idade[posicao]} anos");
    

    Console.ResetColor();
}

