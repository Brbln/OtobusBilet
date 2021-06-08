using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class SehirController : Controller
    {
        SehirManager sehirManager = new SehirManager(new EfSehirDal());

        public IActionResult Index()
        {
            var sehirValue = sehirManager.GetAll();
            return View(sehirValue);
        }
        [HttpGet]
        public ActionResult AddSehir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSehir(Sehir sehir)
        {
            sehirManager.Add(sehir);
            return RedirectToAction("Index");

        }
        public ActionResult DeleteSehir(int id)
        {
            var sehirvalue = sehirManager.GetById(id);
            sehirManager.Delete(sehirvalue);
            return RedirectToAction("Index");

        }
    }
}
