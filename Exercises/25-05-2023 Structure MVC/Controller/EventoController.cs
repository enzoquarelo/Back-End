using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _25_05_2023_Structure_MVC.Model;
using _25_05_2023_Structure_MVC.View;

namespace _25_05_2023_Structure_MVC.Controller
{
    public class EventoController
    {
        Evento evento = new Evento();
        EventiView eView = new EventiView();
        public void ListarEventos()
        {
            List<Evento> Eventos = Evento.Ler();

            eView.Listar(Eventos);
        }
        public void CadastrarEvento()
        {
            Evento novoEvento = eView.Cadastrar();
            evento.Inserir(novoEvento);

        }
    }
}