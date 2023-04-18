// Crie um programa para calcular a idade de uma pessoa em meses-dias-horas-minutos

Console.WriteLine($@"Informe o ano de seu nascimento :");
int anonasc = int.Parse(Console.ReadLine());

var date = DateTime.Now;

int idade = date.Year - anonasc;

Console.WriteLine($"A sua idade atual em anos é de {idade} anos.");

float meses = idade * 12;
Console.WriteLine($"A sua idade em meses é de {meses} meses");

float dias = idade * 365;
Console.WriteLine($"A sua idade em dias é de {dias} dias");

float horasnoano = 24*365;
float horas = idade * horasnoano;
Console.WriteLine($"A sua idade em horas é de {horas} horas");

float minutos = idade * (60*horasnoano);
Console.WriteLine($"A sua idade em minutos é de {minutos} minutos");
