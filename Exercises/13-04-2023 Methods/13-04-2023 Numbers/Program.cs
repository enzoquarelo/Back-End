//  Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o menor valor lido.

int[] valores = new int [10];

for(int i = 0; i < 10; i++ )
{
 Console.WriteLine($"Digite o {i}º numero:");
 valores[i] = int.Parse(Console.ReadLine());
}

int maior = valores[0];
int menor = valores[0];

for (int i = 1; i < 10; i++)
{
    if (valores[i] > maior)
    {
        maior = valores[i];
    }

    if (valores[i] < menor)
    {
        menor = valores[i];
    }
}

Console.WriteLine($"O maior valor digitado foi {maior}");
Console.WriteLine($"O menor valor digitado foi {menor}");



