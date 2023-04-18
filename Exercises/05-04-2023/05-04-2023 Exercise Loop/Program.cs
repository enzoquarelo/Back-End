//Faça um programa que leia e valide as seguintes informações:
// 1. Nome: diferente de vazio;
// 2. Idade: entre 0 e 100 anos;
// 3. Salário: maior que zero;
// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

Console.WriteLine(@$"
 ___________________________________
|                                   |
|    Bem-Vindo ao nosso programa!   |  
|   Faça o seu cadastro conosco :)  |
|___________________________________| 
");

Console.WriteLine($"Por-favor informe o seu nome completo:");
string name = Console.ReadLine();


while(name.Length == 0)
{
    Console.WriteLine($"Complete o campo para seguir o cadastro !");
    name = Console.ReadLine();
}

Console.WriteLine($"Por-favor informe sua idade:");
int age = int.Parse(Console.ReadLine());

while(age <= 0 || age > 100)
{
    Console.WriteLine($"Informe uma idade valida.");
    age = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Por-favor informe sua renda mensal:");
float wage = float.Parse(Console.ReadLine());

while(wage <= 0)
{
    Console.WriteLine($"Informe uma renda valida!");
    wage = float.Parse(Console.ReadLine());
}

Console.WriteLine(@$"
 __________________________________________
|                                         |
|   Agora para completarmos seu cadastro  |
|     nos informe seu estado civil :      |
|                                         |
|Complete com () para ...                 |
|(s) para solteiro                        |
|(c) para casado                          |
|(v) para viuvo                           |
|(d) para divorciado                      |
|_________________________________________|
");

Console.WriteLine($"Informe seu estado civil de acordo com as instrucoes acima :");
string status = Console.ReadLine().ToLower();

while(status != "s" && status != "c" && status != "v" && status != "d")
{
    Console.WriteLine($"Informe utilizando as instrucoes dadas acima :");
    status = Console.ReadLine().ToLower();
}

Console.WriteLine($"Cadatro Completo ! Seja muito Bem-Vindo {name} ;)");



