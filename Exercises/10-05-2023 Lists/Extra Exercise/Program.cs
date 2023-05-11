//EXERCÍCIO PARA FIXAÇÃO - NÃO PRECISA ENTREGAR

//1 - CRIAR UMA CLASSE "CARRO"
//      - PROPRIEDADES : STRING MARCA, STRING COR

//2 - CRIAR CONSTRUTOR VAZIO E COMPLETO

//3 - CADASTRAR E INSERIR EM UMA LISTA 2 OBJETOS(DINÂMICO)
//      - ENTRADA DE DADOS PELO CONSOLE 

//4 - EXIBIR OS DADOS DOS OBJETOS NO CONSOLE (FOREACH)

using Extra_Exercise;

List<Carro> listCarro = new List<Carro>();

listCarro.Add(new Carro("BMW","Vermelho"));
listCarro.Add(new Carro("Fiat","Cinza"));

foreach (var item in listCarro)
{
    Console.WriteLine(@$"
    Produto Carro:
    Marca: {item.Marca}
    Cor: {item.Cor}
    ");
    
}