using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleList
{
    internal class Datuak
    {
        public string Izena;
        public Datuak(string izena)
        { 
            this.Izena = izena; 
        }

        public static string DatuenZerrenda(List<Datuak> datuenLista)
        {
            string mezua = "";
            foreach (Datuak datua in datuenLista)
            {
                mezua += datua.Izena;
            }
            return mezua;
        }

    }
}
