// Somar (primeiroNumero, segundoNumero)

//criar os metodos paraas demais operacoes (-, *, /)
//receber os numeros e exibir os resultados

Console.WriteLine(@$"
 _____________________________
| Informe a operacao desejada |
|                             |
| 1-  Soma                    |
| 2-  Subtracao               |
| 3-  Divisao                 |
| 4-  Multiplicacao           |
|_____________________________|
");
char operacao = char.Parse(Console.ReadLine());

Console.WriteLine($"Informe o Primeiro numero :");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o Segundo numero :");
float n2 = float.Parse(Console.ReadLine());

static float somar(float n1, float n2)
{
    return (n1 + n2);
}

static float subtrair(float n1, float n2)
{
    return (n1 - n2);
}

static float multiplicacao(float n1, float n2)
{
    return (n1 * n2);
}

static float dividir(float n1, float n2)
{
    return (n1 / n2);
}

switch (operacao)
{
    case '1':
        Console.WriteLine($"A soma de {n1} + {n2} é {somar(n1, n2)}");
        break;

    case '2':
        Console.WriteLine($"A subtração de {n1} - {n2} é {subtrair(n1, n2)}");
        break;

    case '3':
        Console.WriteLine($"A multiplicação de {n1} * {n2} é {multiplicacao(n1, n2)}");
        break;

    case '4':
        Console.WriteLine($"A divisão de {n1} / {n2} é {dividir(n1, n2)}");
        break;

    default:
        Console.WriteLine($"Voce precisa escolher uma das operacoes validas !");
        break;
}


