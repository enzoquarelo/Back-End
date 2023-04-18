// Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.WriteLine(@$"
 _____________________________
| Bem-Vindo ao nosso Programa |
|                             |
|    Vamos conferir seu       |
|   status para a votacao     |
|_____________________________|
");

Console.WriteLine($"Pressione <Enter> para seguir!");
Console.ReadLine();

Console.WriteLine($"Informe o ano de seu nascimento :");
int ano = int.Parse(Console.ReadLine());

int anoatual = DateTime.Now.Year;

int avaliacao = anoatual - ano;

if(avaliacao >= 16)
{
    Console.WriteLine($"Voce e apto para votar, porem sem obrigacoes.");
}

else if (avaliacao >= 18)
{
    Console.WriteLine($"Voce tem como responsabilidade de cidadao brasileiro, contribuir com a votacao");
}

else if (avaliacao > 70)
{
    Console.WriteLine($"Voce ainda e apto para votar, porem sem obrigacoes.");
}


