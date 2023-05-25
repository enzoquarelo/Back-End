using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _25_05_2023_Structure_MVC.Model;

namespace _25_05_2023_Structure_MVC.View
{
    public class EventiView
    {
        public void Listar(List<Evento> Evento)
        {
            foreach (var item in Evento)
            {
                Console.WriteLine(@$"
                Evento -> ({item.Data}
                Nome : {item.Nome}
                Descricao : {item.Descricao})");

            }
        }
        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"Informe o dia do evento:");
            novoEvento.Data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Informe o nome desse evento:");
            novoEvento.Nome = Console.ReadLine();
            Console.WriteLine($"Informe a descricao do evento:");
            novoEvento.Descricao = Console.ReadLine();

            return novoEvento;
        }
    }
}