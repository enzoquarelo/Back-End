// Crie uma classe abstrata denominada Elevador para armazenar as informações de um elevador
//dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
//no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
//presentes nele. A classe deve também disponibilizar os seguintes métodos:
//Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
//andares no prédio (os elevadores sempre começam no térreo e vazio);
//Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
//espaço);
//Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
//dentro dele);
//Subir : para subir um andar (não deve subir se já estiver no último andar);
//Descer : para descer um andar (não deve descer se já estiver no térreo);
//Encapsular todos os atributos da classe (criar os métodos set e get).

namespace Elevator
{
    public class Elevador
    {
        public char SairElevador;
        public char OpcaoMenu { get; set; }
        public int AndarAtual = 0;
        public int Capacidade = 8;
        public int PessoasAtual { get; set; }

        public void Loading(string texto, int pontos, int tempo)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(texto);

            for (var i = 0; i < pontos; i++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
            }

            Console.ResetColor();
        }

        public void MenuElevador()
        {
            Console.WriteLine(@$"
            Bem-vindo, escolha a opcao desejada:
            Andar Atual = {AndarAtual}º
            [1] Subir
            [2] Descer
            [3] Sair");
            OpcaoMenu = char.Parse(Console.ReadLine());
        }

        public void Entrar()
        {
            if (PessoasAtual < Capacidade)
            {
                MenuElevador();
            }
            else if (PessoasAtual >= Capacidade)
            {
                Console.WriteLine($"Infelizmente o Elevador ja esta com seu numero maximo de pessoas suportadas.");
            }
        }
        public void Subir()
        {
            if (AndarAtual >= 0 && AndarAtual < 10)
            {
                Loading("Subindo", 5, 1);
                AndarAtual++;

            }
            else if (AndarAtual == 10)
            {
                Console.WriteLine($"Voce ja se encontra no andar mais alto, por-favor selecione uma opcao do menu diferente de Subir");
            }
        }
        public void Descer()
        {
            if (AndarAtual > 0)
            {
                Loading("Descendo", 5, 1);
                AndarAtual--;
            }
            else if (AndarAtual == 0)
            {
                Console.WriteLine($"Voce ja se encontra no andar mais baixo, por-favor selecione uma opcao do menu diferente de Descer");
                MenuElevador();
            }
        }
        public void Sair()
        {
            Console.WriteLine(@$"
            Voce tem certeza que deseja sair? Voce esta no {AndarAtual}º andar.
            [1] Sair
            [2] Permanecer");
            SairElevador = char.Parse(Console.ReadLine());
            switch (SairElevador)
            {
                case '1':
                    Console.WriteLine($"Voce saiu no {AndarAtual}º andar.");
                    break;
                case '2':
                    MenuElevador();
                    break;
                default:
                    Console.WriteLine($"Opcao invalida, Tente Novamente:");
                    OpcaoMenu = char.Parse(Console.ReadLine());
                    break;
            }

        }
    }
}