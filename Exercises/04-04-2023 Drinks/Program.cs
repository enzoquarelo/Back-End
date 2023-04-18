//Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções. A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo. Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.

Console.WriteLine(@$"
 ________________________________
| Bem-vindo! Informe sua Bebida: |
| Digite ...                     |
|                                |
| 1 para CocaCola                |
| 2 para Caipirinha              |
| 3 para Cafe                    |
| 4 para Chocolate Quente        |
|________________________________|");

string bebida = Console.ReadLine().ToLower();

switch (bebida)
{
    case "1":
        Console.WriteLine($"Deseja acrescentar gelo a sua bebida ? Digite s para Sim ou n para Nao !");
    break; 

    case "2":
        Console.WriteLine($"Deseja acrescentar gelo a sua bebida ? Digite s para Sim ou n para Nao !");
    break; 
    
}

string gelo = Console.ReadLine().ToLower();

switch (gelo)
{
    case "s":
        Console.WriteLine($"Sua bebida tera um adicional de gelo !");
    break; 

    case "n":
        Console.WriteLine($"Sua bebida sera sem gelo adicional !");
    break; 
}

Console.WriteLine($"Obrigado pela preferencia! Tenha um otimo dia :)");



