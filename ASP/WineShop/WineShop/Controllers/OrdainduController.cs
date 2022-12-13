using Microsoft.AspNetCore.Mvc;

using WineShop.Data;
using WineShop.Models;
using Microsoft.AspNetCore.Authorization;
using WineShop.Services;
using Newtonsoft.Json;
using System.Text;
using WineShop.ViewModels;

namespace WineShop.Controllers
{
    [Authorize]
    public class OrdainduController : Controller
    {
        private readonly ISaskiaService _saskiaService;
        public OrdainduController(ISaskiaService saskiaService)
        {
            _saskiaService = saskiaService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Abizena,Helbidea,Herrialdea,Hiria,Izena,Postakodea,Telefonoa")]
            BezeroaEskaera bezeroaEskaera)
        {
            if (ModelState.IsValid)
            {
                /*Bezeroen datuak gorde*/
                bezeroaEskaera.Erabiltzailea = HttpContext.User.Identity.Name;
                bezeroaEskaera.Data = DateTime.Now;
                await _saskiaService.EskaeraBezeroaGehitu(bezeroaEskaera);
                /*Eskaera gorde*/
                var cart = Saskia.SaskiaLortu(this.HttpContext);
                await _saskiaService.EskaeraSortu(bezeroaEskaera, cart.SaskiaId);
                /*Beste pantaila batera berbideratzen da*/
                return RedirectToAction("Osatu", new
                {
                    bezeroa = bezeroaEskaera.Izena + " " + bezeroaEskaera.Abizena,
                    saskiaId = cart.SaskiaId
                });
            }
            return View(bezeroaEskaera);
        }

        public async Task EskaeraSortu(BezeroaEskaera bezeroaEskaera, string saskiaId)
        {
            var cartItems = await _saskiaService.SaskiaLortuAleak(saskiaId);
            foreach (var item in cartItems)
            {
                var erosketa = new Erosketa
                {
                    ArdoaId = item.ArdoaId,
                    BezeroaEskaeraId = bezeroaEskaera.Id,
                    Kantitatea = item.Kantitatea
                };
                Uri rutaErosketa = new Uri("https://localhost:44367/api/Erosketa/");
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(erosketa), Encoding.UTF8,
                    "application/json");
                    var response = await httpClient.PostAsync(rutaErosketa, content);
                    response.EnsureSuccessStatusCode();
                }
            }
        }

        public async Task<IActionResult> Osatu(string bezeroa, string saskiaId)
        {
            var osatuViewModel = new OsatuViewModel(); //ViewModel bat erabiliko dugu
            osatuViewModel.SaskiaAleak = await _saskiaService.SaskiaLortuAleak(saskiaId);
            osatuViewModel.SaskiaId = saskiaId;
            osatuViewModel.Bezeroa = bezeroa;
            return View(osatuViewModel);
        }
    }
}
