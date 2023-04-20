namespace C__POO
{
    public class Personagem
    {
        public string nome = "Tony Stark";
        public int idade = 35;
        public string armadura = "Bleeding Edge";
        public string ia = "Sexta-Feira";

        public void Atacar()
        {
            Console.WriteLine($"O personagem atacou.");
        }

        public string Defender()
        {
           
            return  "O personagem defendeu.";
        }

        public void RestaurarArmadura()
        {
            Console.WriteLine($"O personagem restaurou sua armadura ({armadura})");
            
        }
    }
}