using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace AginteKoadroa.Models
{
    public partial class Salmenta
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Zenbatekoa { get; set; }
        public string BezeroaId { get; set; }
        public virtual Bezeroa Bezeroa { get; set; }
    }
}