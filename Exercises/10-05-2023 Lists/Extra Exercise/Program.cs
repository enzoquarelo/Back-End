//EXERCÍCIO PARA FIXAÇÃO - NÃO PRECISA ENTREGAR

//1 - CRIAR UMA CLASSE "CARRO"
//      - PROPRIEDADES : STRING MARCA, STRING COR

//2 - CRIAR CONSTRUTOR VAZIO E COMPLETO

//3 - CADASTRAR E INSERIR EM UMA LISTA 2 OBJETOS(DINÂMICO)
//      - ENTRADA DE DADOS PELO CONSOLE 

//4 - EXIBIR OS DADOS DOS OBJETOS NO CONSOLE (FOREACH)

using Extra_Exercise;

Carro carro = new Carro();
List<Carro> listCarro = new List<Carro>();

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Cadastro do {i + 1}º carro:");
    Console.Write("Marca: ");
    string marca = Console.ReadLine();
    Console.Write("Cor: ");
    string cor = Console.ReadLine();

    listCarro.Add(new Carro(marca, cor));
}

Console.WriteLine("Dados dos carro cadastrados:");
foreach (var item in listCarro)
{
    Console.WriteLine(@$"
    Marca: {item.Marca}
    Cor: {item.Cor}");
}