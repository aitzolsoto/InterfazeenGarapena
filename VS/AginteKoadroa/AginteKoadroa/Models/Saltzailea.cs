using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace AginteKoadroa.Models
{
    public partial class Saltzailea
    {
        [Key]
        public string Id { get; set; }
        public string Izena { get; set; }
        public string Taldea { get; set; }
        public virtual List<Bezeroa> Bezeroa { get; set; }
    }
}
