using Microsoft.AspNetCore.Mvc;
using WineShop.Models;
using WineShop.Services;
using WineShop.VIewModels;

namespace WineShop.ViewComponents
{
    public class SaskiaViewComponent : ViewComponent
    {
        private readonly ISaskiaService _saskiaService;


        public SaskiaViewComponent(ISaskiaService saskiaService)
        {
            _saskiaService = saskiaService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            List<SaskiaAlea> lista = await _saskiaService.SaskiaLortuAleak(id);
            ViewBag.kant = lista.Count;
            return View(await _saskiaService.SaskiaLortuAleak(id));
        }
    }
}
