﻿// 2. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
 
//● Total de Homens;

//● Total de Mulheres;

//●Média de idade dos Homens;

//●Média de idade das mulheres.

Console.WriteLine(@$"
 _____________________________________
|    Bem-Vindo ao Nosso Programa !    |
|                                     |
|          Pesquisa Social            |
|_____________________________________|
");

int homens = 0, mulheres = 0, homensAge = 0, mulheresAge = 0, somaIdadeHomens = 0, somaIdadeMulheres = 0, mediaHomens = 0, mediaMulheres = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Para sua seguranca e sigilo o unico pedido que fazemos e que nos informe o seu sexo.(informe M para Masculino e F para Feminino).");
    char sexo = char.Parse(Console.ReadLine().ToLower());

    Console.WriteLine($"Qual a sua Idade?");
    int idade = int.Parse(Console.ReadLine().ToLower());

    Console.WriteLine($"Qual o seu Peso?");
    float peso = float.Parse(Console.ReadLine().ToLower());

    if (sexo == 'm')
    {
        homens++;
    }

    else if (sexo == 'f')
    {
        mulheres++;
    }

    if (sexo == 'm')
    {
        somaIdadeHomens = somaIdadeHomens + idade;
    }

    else if (sexo == 'f')
    {
        somaIdadeMulheres = somaIdadeMulheres + idade;
    }
}

mediaHomens = somaIdadeHomens/homens;
mediaMulheres = somaIdadeMulheres/mulheres;

Console.WriteLine($"O total de homens que responderam a pesquisa equivale a {homens},o total de mulheres que responderam a pesquisa equivale a {mulheres}. A media da idade de homens e de {mediaHomens}anos e a media de idade de mulheres e de {mediaMulheres}anos!");