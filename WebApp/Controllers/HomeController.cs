using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ISehirService _sehirService;
        private ISeferService _seferService;

        public HomeController(ILogger<HomeController> logger, ISehirService sehirService, ISeferService seferService)
        {
            _logger = logger;
            this._seferService = seferService;
            this._sehirService = sehirService;
        }

        public IActionResult Index(string nereden, string nereye)
        {
            if (nereden == null || nereye == null || nereden == nereye)
            {
                var sehirModel = new BiletSefer()
                {
                    Sehirler = _sehirService.GetAll(),
                    Seferler = null
                };

                ViewBag.Sehirler = new SelectList(sehirModel.Sehirler, "SehirId", "SehirAdi");
                return View(sehirModel);
            }
            else
            {
                var sehirModel = new BiletSefer()
                {
                    Sehirler = _sehirService.GetAll(),
                    Seferler = _seferService.GetYolculuk(nereden, nereye)
                };
                TempData["nereden"] = _seferService.GetNereden(nereden);
                TempData["nereye"] = _seferService.GetNereye(nereye);
                ViewBag.Sehirler = new SelectList(sehirModel.Sehirler, "SehirId", "SehirAdi");
                return View(sehirModel);
            }


        }
        public IActionResult AdminPage()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Iletisim()
        {
            ViewData["title"] = "İletişim - ";
            return View();
        }
    }
}
