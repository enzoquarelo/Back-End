//Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

Console.WriteLine($"Informe o valor do seu salário:");
double salário = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe os seus gastos neste mês após receber seu salário:");
double gastos = double.Parse(Console.ReadLine());

double saldo = salário - gastos;

if(saldo >= 0)
{
 Console.WriteLine($"Gastos dentro do orçamento");
}
else if(saldo < 0)
{
    Console.WriteLine($"Orçamento estourado!");
}