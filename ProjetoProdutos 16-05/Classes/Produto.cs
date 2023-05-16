using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCadastro_16_05.Classes
{
    public class Produto
    {
        private int Codigo {get; set;}
        private string NomeProduto {get; set;}
        private float Preco {get; set;}
        private DateTime DataCadastro = DateTime.Now;
        private Marca Marca {get; set;}
        private Usuario CadastradoPor {get; set;}
        private List<Produto> ListaDeProdutos {get; set;}

        public string Cadastrar()
        {

        }
        public List<Produto> Listar()
        {

        }
        public string Deletar()
        {
            
        }
    }
}