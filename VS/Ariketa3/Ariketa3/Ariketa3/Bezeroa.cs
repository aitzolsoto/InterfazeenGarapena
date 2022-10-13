using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    internal class Bezeroa : Kontaktua
    {
        public string Kategoria { get; set; }

        public override string Gorde()
        {
            return "Bezeroa ondo gorde da";
        
        }
    }
}
