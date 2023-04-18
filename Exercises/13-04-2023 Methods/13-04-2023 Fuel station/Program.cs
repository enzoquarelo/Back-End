//  Um posto está vendendo combustíveis com a seguinte tabela de descontos:
//Álcool: 
//. até 20 litros, desconto de 3% por litro Álcool 
//. acima de 20 litros, desconto de 5% por litro 
//Gasolina: 
//. até 20 litros, desconto de 4% por litro Gasolina 
//. acima de 20 litros, desconto de 6% por litro
//Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
//Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

Console.WriteLine(@$"
 _____________________________________________________
|              Bem-vindo(a) ao nosso posto!           |
|Escolha o tipo de combustível que irá abastecer hoje:|
|A- álcool                                            |
|G- gasolina                                          |
|_____________________________________________________|
");
char combustivel = char.Parse(Console.ReadLine().ToUpper());

Console.WriteLine($"Qual a litragem a ser inserida em seu altomovel?");
int litros = int.Parse(Console.ReadLine());


if (combustivel == 'A')
{
    float preco = (float)(litros * 4.90);

    if (combustivel == 'A' && litros <= 20)
    {
        float desconto = CalculoDesconto(preco, 3);
        Console.WriteLine(@$"Seu abastecimento deu R${preco} com o desconto de R${desconto}. Ou seja, seu total será de R${preco - desconto}");
    }
    else if (combustivel == 'A' && litros > 20)
    {
        float desconto = CalculoDesconto(preco, 5);
        Console.WriteLine(@$"Seu abastecimento deu R${preco} com o desconto de R${desconto}. Ou seja, seu total será de R${preco - desconto}");
    }
    else
    {
        Console.WriteLine($"Não foi possível calcular. Tente novamente");
    }
}
else if (combustivel == 'G')
{
    float preco = (float)(litros * 5.30);

    if (combustivel == 'G' && litros <= 20)
    {
        float desconto = CalculoDesconto(preco, 4);
        Console.WriteLine(@$"Seu abastecimento deu R${preco} com o desconto de R${desconto}. Ou seja, seu total será de R${preco - desconto}");
    }
    else if (combustivel == 'G' && litros > 20)
    {
        float desconto = CalculoDesconto(preco, 6);
        Console.WriteLine(@$"Seu abastecimento deu R${preco} com o desconto de R${desconto ,2}. Ou seja, seu total será de R${preco - desconto ,2}");
    }
    else
    {
        Console.WriteLine($"Não foi possível calcular. Tente novamente");
    }
}

static float CalculoDesconto(float preco, float porcentagem)
{
    return ((porcentagem / 100 * preco));
}
