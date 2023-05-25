using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _25_05_2023_Structure_MVC.Model
{
    public class Evento
    {
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        private const string PATH = "Database/Evento.csv";
        private const string txt = "Texto.txt";

        public Evento()
        {
            string pasta = PATH.Split("/")[0];
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
                File.Create(txt);
            }
        }
        public static List<Evento> Ler()
        {
            List<Evento> listEventos = new List<Evento>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] atributos = item.Split(";");

                Evento e = new Evento();

                e.Data = DateTime.Parse(atributos[0]);
                e.Nome = atributos[1];
                e.Descricao = atributos[2];
                listEventos.Add(e);
            }

            return listEventos;
        }
        public string PreparaLinhaCSV(Evento _e)
        {
            return $"{_e.Data};{_e.Nome};{_e.Descricao}";
        }

        public void Inserir(Evento _e)
        {
            string[] linhas = { PreparaLinhaCSV(_e) };

            File.AppendAllLines(PATH, linhas);
        }
    }
}