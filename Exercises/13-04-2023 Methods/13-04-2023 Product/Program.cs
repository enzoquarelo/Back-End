// Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que: 
//- Se quantidade <= 5 o desconto será de 2% 
//- Se quantidade > 5 e quantidade <=10 o desconto será de 3% 
//- Se quantidade > 10 o desconto será de 5%
//Dica: utilize if / else if / else

using System.Globalization;

Console.WriteLine(@$"
 ___________________________
|      Seja Bem-Vindo !     |
|                           |
| Digite o nome do produto: |
|___________________________|");
string nome = Console.ReadLine();

Console.WriteLine($"Qual sera a quantidade de {nome} a ser comprada?");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine($"Qual o valor da unidade de {nome}?");
float preco = (float) Math.Round(float.Parse(Console.ReadLine()),2);

float desconto = 0;


if (quantidade <= 5)
{
    desconto = 0.02F;
}
else if (quantidade > 5 && quantidade <= 10)
{
    desconto = 0.03F;
}
else
{
    desconto = 0.05F;
}
Console.WriteLine(@$"Segue as informações:
Nome: {nome}
Quantidade: {quantidade}");
Console.Write("Preço:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine((preco * quantidade).ToString("C", new CultureInfo("pt-BR")));
Console.ResetColor();
Console.Write($"Desconto: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine((preco * quantidade * desconto).ToString("C", new CultureInfo("pt-BR")));
Console.ResetColor();
Console.Write($"Total a Pagar: ");
Console.WriteLine(((preco * quantidade) - (preco * quantidade * desconto)).ToString("C", new CultureInfo("pt-BR")));
