namespace Extra_Exercise
{
    public class Carro
    {
        public string Marca {get; set;}
        public string Cor {get; set;}

        public Carro()
        {
            
        }
        public Carro(string marca, string cor)
        {
            Marca = marca;
            Cor = cor;
        }
    }
}