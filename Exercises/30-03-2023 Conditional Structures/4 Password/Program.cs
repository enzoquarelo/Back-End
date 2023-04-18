//Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário. 
//A     senha     válida     é     o     número     1234. 
//Devem     ser    impressas     as    seguintes     mensagens:
//ACESSO    PERMITIDO    caso    a    senha    seja    válida.
//ACESSO    NEGADO    caso    a    senha    seja    inválida.

Console.WriteLine($"Informe a senha:");
int tentativa = int.Parse(Console.ReadLine());

int senha = 1234;

if (tentativa == senha)
{
    Console.WriteLine($"ACESSO PERMITIDO");
}
else
{
    Console.WriteLine($"ACESSO NEGADO");
}