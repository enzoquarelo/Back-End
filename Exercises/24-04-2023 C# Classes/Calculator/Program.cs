using Calculator;

CalculadoraMetodos metodo = new CalculadoraMetodos();

Console.WriteLine(@$"
 _______________________________
|Bem-Vindo a Calculadora        |
|Escolha a operacao desejada :  |
|                               |
|1- Soma (+)                    |
|2- Subtracao (-)               |
|3- Divisao (/)                 |
|4- Multiplicacao (*)           |
|_______________________________|");

Console.WriteLine($"");



char opcaoOperacao = char.Parse(Console.ReadLine());

Console.WriteLine($"Agora por-favor informe os numeros a serem calculados :");
Console.Write($"Primeiro Numero : ");
float n1 = float.Parse(Console.ReadLine());
Console.Write($"Segundo Numero : ");
float n2 = float.Parse(Console.ReadLine());

switch(opcaoOperacao){

    case '1':
        metodo.Soma(n1, n2);
    break;
    case '2':
        metodo.Subtracao(n1, n2);
    break;
    case '3':
        if(n2 == 0 || n1 == 0)
        {
            Console.WriteLine($"Por-Favor para realizar uma divisao informe um numero diferente de 0.");
            
        }
        else
        {
            metodo.Divisao(n1, n2);
        }
    break;
    case '4':
        metodo.Multiplicar(n1, n2);
    break;
}
