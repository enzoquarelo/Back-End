namespace POO_game
{
    public class PokemonInicial
    {
        public void Atacar(string inicial, string ataque, int dano)
        {
            Console.WriteLine($"O {inicial} usou {ataque}, ele causou {dano} de dano ao oponente.");
        }

        public void Curar(string inicial, int cura)
        {
            Console.WriteLine($"Voce restaurou {cura} de HP de {inicial}");
            
        }
    }
}