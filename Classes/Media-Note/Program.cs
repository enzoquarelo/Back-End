// Faça um programa que receba 5 notas de um aluno e calcule a média aritmética. Imprimir a resposta no console.

Console.WriteLine($"Informe o nome do aluno cujo quer calcular a média");
string name = Console.ReadLine();

Console.WriteLine($"Informe a primeira nota do aluno:");
float nota1=float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a segunda nota do aluno:");
float nota2=float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a terceira nota do aluno:");
float nota3=float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a quarta nota do aluno:");
float nota4=float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a quinta nota do aluno:");
float nota5=float.Parse(Console.ReadLine());

float media =  (nota1 + nota2 + nota3 + nota4 + nota5)/5;

Console.WriteLine($"A média do aluno {name} é de {media}");
