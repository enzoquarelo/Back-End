namespace Lists_C_
{
    public class Produto
    {
        public int Codigo {get; set;}
        public float Preco {get; set;}
        public string Nome {get; set;}

        public Produto()
        {
            
        }
        public Produto(int codigo,  float preco,  string nome)
        {
            Codigo = codigo;
            Preco = preco;
            Nome = nome;
        }
    }
}