using Students;

Aluno Aluno= new Aluno();

Console.WriteLine($"Bem-vindo ao Programa de cadastro de alunos :");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"*Precione <Enter> para seguir*");
Console.ResetColor();
Console.ReadLine();

Console.WriteLine($"Informe o nome do aluno :");
Aluno.Nome = Console.ReadLine();
Console.WriteLine($"Informe o curso que {Aluno.Nome} esta cursando :");
Aluno.Curso = Console.ReadLine();
Console.WriteLine($"Informe o RG de {Aluno.Nome} :");
Aluno.RG = int.Parse(Console.ReadLine());
Console.WriteLine($"O(a) {Aluno.Nome} e bolsista ? s/n");
char bolsistaResposta = char.Parse(Console.ReadLine().ToLower());
if(bolsistaResposta == 's')
{
    Aluno.Bolsista = true;
}
else if(bolsistaResposta == 'n')
{
    Aluno.Bolsista = false;
}
else
{
    Console.WriteLine($"Por-favor insira uma resposta valida. s/n");
    bolsistaResposta = char.Parse(Console.ReadLine().ToLower());
}
Console.WriteLine($"Informe a media final de {Aluno.Nome} :");
Aluno.MediaFinal = float.Parse(Console.ReadLine());
Console.WriteLine($"Informe a mensalidade a ser paga por {Aluno.Nome} :");
Aluno.Mensalidade = float.Parse(Console.ReadLine());

char opcaoMenu;

do
{
    Console.WriteLine(@$"
 __________________________
|        Menu Inicial      |
|1- Visualizar Media Final |
|2- Visulizar Mensalidade  |
|3- Conferir Dados         |
|                          |
|0- Sair                   |
|__________________________|");
Console.WriteLine($"");


opcaoMenu = char.Parse(Console.ReadLine());

switch(opcaoMenu)
{
    case '0':
    Console.WriteLine($"Obrigado por utilizar nosso programa !");
    break;
    case '1':
        Aluno.VerMediaFinal();
    break;
    case '2':
        Aluno.VerMensalidade();
    break;
    case '3':
        Aluno.VizualizarDados();
    break;
}

} while (opcaoMenu != 0);




