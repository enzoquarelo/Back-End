namespace Interface_C_
{
    public class Carrinho:ICarrinho
    {
        public float Valor {get; set;}

        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Atualizar(int _codigo, Produto _novoproduto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoproduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoproduto.Preco;
        }

        public void Listar()
        {
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine(@$"Codigo: {p.Codigo} - Nome: {p.Nome} - Preco: {p.Preco:C}");
                }
            }
        }

        public void Remover(Produto _produto)
        {
            throw new NotImplementedException();
        }
    }
}