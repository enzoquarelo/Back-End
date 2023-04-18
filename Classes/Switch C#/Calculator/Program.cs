//vamos criar uma calculadora usando switch case

Console.WriteLine(@$"
Informe a operecao matematica que deseja efetuar:
'+' para somar
'*' para multiplicar
'-' para subtrair
'/' para dividir
");

char operacao = char.Parse(Console.ReadLine());

Console.WriteLine($"Digite o primeiro numero:");
float numero1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero:");
float numero2 = float.Parse(Console.ReadLine());

float resultado = 0;

switch (operacao)
{
    case '+':
        resultado = (numero1 + numero2);
        Console.WriteLine($"O resultado da sua soma e de {resultado}");
        break;
    case '*':
        resultado = (numero1 * numero2);
        Console.WriteLine($"O resultado da sua soma e de {resultado}");
        break;
    case '-':
        resultado = (numero1 - numero2);
        Console.WriteLine($"O resultado da sua soma e de {resultado}");
        break;
    case '/':
        resultado = (numero1 / numero2);
        Console.WriteLine($"O resultado da sua soma e de {resultado}");
        break;

    default:
        Console.WriteLine($"A operacao nao e suportada pela nossa calculadora!");
        break;
}