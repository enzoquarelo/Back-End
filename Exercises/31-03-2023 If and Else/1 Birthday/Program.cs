// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.
Console.WriteLine($"Insira o dia, mês e o ano do seu aniversário. Um por vez:");
int dia = int.Parse (Console.ReadLine());
int mes = int.Parse (Console.ReadLine());
int ano = int.Parse (Console.ReadLine());

if (dia<31 && mes<12 && ano <2013)
{
    Console.WriteLine($"Data válida!");
}
else if (dia>31 || mes>12 || ano>2013)
{
    Console.WriteLine($"Insira uma data válida.");
}
