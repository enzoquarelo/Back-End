//  Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e*voltando a pedir as informações

Console.WriteLine(@$"
 _____________________________________
|    Bem-Vindo ao Nosso Programa !    |
|                                     |
|      Vamos fazer seu cadastro.      |
|_____________________________________|
");

Console.WriteLine($"Por-favor informe seu nome :");
string nome = Console.ReadLine().ToLower();

Console.WriteLine($"Agora Informe uma senha para vc se cadastrar.");
string senha = Console.ReadLine().ToLower();

while (nome == senha)
{
    Console.WriteLine($"Digite uma senha diferente do seu nome de usuário.");
    senha = Console.ReadLine();
}

Console.WriteLine($"Cadastro Finalizado!");



