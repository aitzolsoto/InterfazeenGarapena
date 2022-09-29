using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa2_Zerrenda
{
    internal class Ariketa_4
    {
        public string label;
        public double zenbakia { get; set; }
        public Ariketa_4(double zenbakia)
        {
            this.zenbakia = zenbakia;
        }

        public static double Eragiketa(List<Ariketa_4> objetuak)
        {
            double emaitza = (objetuak[0].zenbakia + (2 * objetuak[1].zenbakia) + (3 * objetuak[2].zenbakia) + (4 * objetuak[3].zenbakia))/4;
            return emaitza;
        }
    }
}
