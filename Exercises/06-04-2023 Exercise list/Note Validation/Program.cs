// Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

Console.WriteLine(@$"
 _____________________________________
|    Bem-Vindo ao Nosso Programa !    |
|                                     |
| Vamos fazer a Validacao da sua nota |
|_____________________________________|
");

Console.WriteLine($"Por-favor informe a nota a ser validada.");
float nota = float.Parse(Console.ReadLine());

while(nota < 0 || nota > 10)
{
    Console.WriteLine($"O valor e invalido, infome a nota novamente");
    nota = float.Parse(Console.ReadLine());
}

Console.WriteLine($"Sua nota foi validada com sucesso!");

