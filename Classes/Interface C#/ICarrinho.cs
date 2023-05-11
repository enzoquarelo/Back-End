namespace Interface_C_
{
    public interface ICarrinho
    {
        // Definir(declarar) quais os métodos deverão ser implementados
        // na classe que herdar desta interface
        // CRUD : Create Read Update Delete
        // Create
        void Adicionar(Produto _produto);
        // Listar
        void Listar();
        // Update
        void Atualizar(int _codigo, Produto _produto);
        // Delete
        void Remover(Produto _produto);
    }
}