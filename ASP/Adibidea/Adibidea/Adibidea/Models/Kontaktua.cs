namespace Adibidea.Models
{
    public class Kontaktua
    {
        public string nan { get; set; }
        public string izena { get; set; }
        public string abizena { get; set; }
        public virtual string emaila { get; set; }
        public string izenOsoa { get { return izena + "" + abizena; } }
        public Kontaktua(string nan, string izena, string abizena)
        {
            this.nan = nan;
            this.izena = izena;
            this.abizena = abizena;
        }

        public virtual string Gorde()
        {
            return "Kontaktua ondo gorde da";
        }
    }
}
