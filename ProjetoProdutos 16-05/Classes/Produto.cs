using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCadastro_16_05.Classes
{
    public class Produto
    {
        private int Codigo { get; set; }
        private string NomeProduto { get; set; }
        private float Preco { get; set; }
        private DateTime DataCadastro { get; set; }
        private Marca Marca { get; set; }
        private Usuario CadastradoPor { get; set; }
        private List<Produto> ListaDeProdutos { get; set; }
        
        public Produto(string nomeProduto, float preco, int codigo, Marca marca, Usuario cadastradoPor, DateTime dataCadastro)
        {
            Codigo = codigo;
            NomeProduto = nomeProduto;
            Preco = preco;
            Marca = marca;
            CadastradoPor = cadastradoPor;
            DataCadastro = dataCadastro;
        }

        List<Produto> listProduto = new List<Produto>();
        public string Cadastrar(string novoProduto, int )
        {
            Console.WriteLine($"Vamos realizar o cadastro do Produto :");
            Console.Write($"Informe o codigo do Produto:");
            Codigo = int.Parse(Console.ReadLine());
            Console.Write($"Informe o nome do Produto:");
            NomeProduto = Console.ReadLine();
            Console.Write($"Informe o preco do Produto:");
            Preco = float.Parse(Console.ReadLine());
            Console.Write($"Informe o codigo da marca do Produto:");
            int codigoMarca = int.Parse(Console.ReadLine());

            DataCadastro = DateTime.Now;

            listProduto.Add(new Produto());

            return novoProduto;
        }
        public List<Produto> Listar()
        {

        }
        public void Deletar()
        {

        }
    }

}