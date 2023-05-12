using Interface_C_;

Carrinho carrinho = new Carrinho();

Produto p1 = new Produto(1, "Call od Duty", 480f);
Produto p2 = new Produto(2, "Minerinho Ultra Adventures", 2.30f);
Produto p3 = new Produto(3, "The last of Us", 150f);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();
