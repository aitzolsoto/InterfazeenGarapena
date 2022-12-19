using WineShop.Models;
using WineShop.VIewModels;

namespace WineShop.ViewModels
{
    public class OsatuViewModel
    {
        public string Bezeroa { get; set; }
        public string SaskiaId { get; set; }
        public IList<SaskiaAleaViewModel> SaskiaAleaVMList { get; set; }
        public IList<SaskiaAlea> SaskiaAleak { get; set; }
    }
}
