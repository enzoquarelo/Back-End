// Escreva um algoritmo que pergunte a idade de um artista famoso e continue perguntando até ela acertar a idade correta.

Console.WriteLine(@$"
 _____________________________________
|    Quiz 'Voce conhece o Artista?'   |
|                                     |
|O quiz sera sobre o Cristiano Ronaldo|
|_____________________________________|
");

int answer = 0;

do{
    Console.WriteLine($"Qual a idade do Cristiano Ronaldo?");
    answer = int.Parse(Console.ReadLine());
}
while(answer != 38);

Console.WriteLine($"Parabens ! Voce respondeu corretamente ao quiz :)");

