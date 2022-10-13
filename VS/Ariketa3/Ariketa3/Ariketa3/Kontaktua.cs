using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Kontaktua
    {
        public string Nan { get; set; }
        public string Izena { get; set; }

        public string Abizena { get; set; }

        public virtual string Emaila { get; set; }

        public string IzenOsoa { get => Izena + " " + Abizena; }

        public virtual string Gorde()
        {
            return "Kontaktua ondo gorde da";

        }
    }
}
