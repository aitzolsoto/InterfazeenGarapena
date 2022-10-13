using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Kontaktua
    {
        public string Izena { get; set; }
        public string Abizena { get; set; }
        public virtual string Emaila { get; set; }
        public string IzenOsoa { get;}

        public virtual string Gorde()
        {
            //Console.WriteLine("Kontaktua ondo gorde da");
            return "Kontaktua ondo gorde da";
        }
    }
}
