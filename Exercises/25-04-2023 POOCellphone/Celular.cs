//Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
//Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
//Só será possível executar tais métodos se o celular estiver ligado.
//Envie o link do repositório como entrega desta atividade.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _25_04_2023_POOCellphone
{
    public class Celular
    {
        public string destinatario;
        public string mensagem;
        public string numero;
        public string Cor;
        public string Modelo;
        public double Tamanho;
        public bool Ligado;
        public string escolhaMenu;

        public void Ligar()
        {
            Ligado = true;
            Console.WriteLine("O celular está ligado.");
        }

        public void Desligar()
        {
            Ligado = false;
            Console.WriteLine("O celular está desligado.");
        }

        public void FazerLigacao()
        {
            Console.WriteLine($"Para quem deseja ligar ?");
            Console.WriteLine($"Eduardo - (xx) XXXXX-XXXX");
            Console.WriteLine($"Carlos - (xx) XXXXX-XXXX");
            Console.WriteLine($"Julia - (xx) XXXXX-XXXX");
            Console.WriteLine($"Gabriel - (xx) XXXXX-XXXX");
            Console.WriteLine($"Andre - (xx) XXXXX-XXXX");

            numero = Console.ReadLine();


            if (Ligado)
            {
                Console.WriteLine($"Discando para {numero}...");
            }
            else
            {
                Console.WriteLine("O celular está desligado. Não é possível fazer uma ligação.");
            }
        }

        public void EnviarMensagem()
        {
            Console.WriteLine($"Para quem deseja mandar mensagem ?");
            Console.WriteLine($"Eduardo - (xx) XXXXX-XXXX");
            Console.WriteLine($"Carlos - (xx) XXXXX-XXXX");
            Console.WriteLine($"Julia - (xx) XXXXX-XXXX");
            Console.WriteLine($"Gabriel - (xx) XXXXX-XXXX");
            Console.WriteLine($"Andre - (xx) XXXXX-XXXX");

            destinatario = Console.ReadLine();

            if (Ligado)
            {
                Console.WriteLine($"Digite sua mensagem para {destinatario}:");
                mensagem = Console.ReadLine();
                
            }
            else
            {
                Console.WriteLine("O celular está desligado. Não é possível enviar uma mensagem.");
            }
        }

        public void MenuCelular()
        {
            Console.WriteLine(@$"
         ______________________________
        |                              |
        |                              |
        |                              |
        | 1) Fazer Ligacao             |
        | 2) Enviar Mensagem           |
        | 3) Desligar                  |
        |                              |
        |                              |
        |                              |
        |                              |
        |                              |
        |______________________________|
        |______________________________|");

            escolhaMenu = Console.ReadLine().ToLower();

        }
    }
}