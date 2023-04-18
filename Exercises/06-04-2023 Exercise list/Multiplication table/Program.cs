// Faça um programa que receba um número inteiro e mostre a sua tabuada.

Console.WriteLine(@$"
 _____________________________________
|    Bem-Vindo ao Nosso Programa !    |
|                                     |
|    Vou te ajudar a multiplicar      |
|_____________________________________|
");

Console.WriteLine($"Informe o numero a ser analisado !");
int numero = int.Parse(Console.ReadLine());


for (int i = 0; i <= 10; i++)
{
    int result = numero * i;
    Console.WriteLine($"{numero} * {i} = {result}");
}
