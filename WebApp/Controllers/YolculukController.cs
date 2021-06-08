using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace EmirBilet.webui.Controllers
{
    public class YolculukController : Controller
    {
        private ISeferService _seferService;
        private IBiletService _biletService;
        public IActionResult Index()
        {
            return View();
        }
        public YolculukController(ISeferService seferService, IBiletService biletService)
        {
            this._seferService = seferService;
            this._biletService = biletService;
        }
        public IActionResult Details(int id)
        {
            Sefer sefer = _seferService.GetSeferDetails(id);
            int seferKoltukSayisi = _biletService.GetCountByKoltuk(id);
            List<int> dolukoltuklar = _biletService.GetKoltuk(id);
            var koltuklar = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            foreach (var item in dolukoltuklar)
            {
                koltuklar.Remove(item);
            }
            var cinsiyet = new List<string>() { "Kadın", "Erkek" };
            ViewBag.Cinsiyet = new SelectList(cinsiyet);
            ViewBag.Sayi = seferKoltukSayisi;
            ViewBag.Koltuklar = new SelectList(koltuklar);
            if (sefer == null)
            {
                return NotFound();
            }
            else
            {
                return View(sefer);
            }
        }

        [HttpPost]
        public IActionResult Details(int seferId, string cinsiyet, string kimlikno, string telno, decimal fiyat, string nereden, string nereye, int koltukno, string email, string isim, string soyisim)
        {
            var entity = new Bilet()
            {
                Ad = isim,
                Soyad = soyisim,
                Mail = email,
                Nereden = nereden,
                Nereye = nereye,
                KoltukNo = koltukno,
                Cinsiyet = cinsiyet,
                KimlikNo = kimlikno,
                TelNo = telno,
                Fiyat = _biletService.GetFiyat(seferId),
                SeferId = seferId
            };
            _biletService.Add(entity);
            return RedirectToAction("Basarili");
        }
        public IActionResult Basarili()
        {
            Bilet yeni = _biletService.GetSonKayit();
            int seferid = _biletService.GetId();
            string sefersaat = _biletService.GetSaat(seferid);
            string sefertarih = _biletService.GetTarih(seferid);
            decimal seferfiyat = _biletService.GetFiyat(seferid);

            var Biletsefer = new BiletSefer()
            {
                tarih = sefertarih,
                saat = sefersaat,
                fiyat = seferfiyat,
                bilet = yeni
            };
            return View(Biletsefer);
        }
    }
}