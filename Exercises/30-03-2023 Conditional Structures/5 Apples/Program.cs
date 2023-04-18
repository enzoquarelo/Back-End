// As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.
Console.WriteLine($"Bem-Vindo! Quantas maçãs deseja comprar?");
int fruta = int.Parse(Console.ReadLine());

if(fruta >= 12)
{
    double pagar = fruta*0.25f;
    Console.WriteLine($"O preco a ser pago e de R${pagar}");
}
else if(fruta <= 6)
{
     double pagar = fruta * 0.3;
     Console.WriteLine($"O preco a ser pago e de R${pagar}");
}