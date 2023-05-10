using Lists_C_;

List<Produto> listProduto = new List<Produto>();

listProduto.Add(new Produto(134, 178.99f, "camisetaNike"));
listProduto.Add(new Produto(135, 119.99f, "camisetaVans"));

foreach (var item in listProduto)
{
    Console.WriteLine(@$"
    Codigo : {item.Codigo}
    Nome do Produto : {item.Nome}
    Preco do Produto : {item.Preco:C}");
    
}