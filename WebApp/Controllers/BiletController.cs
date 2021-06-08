using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class BiletController : Controller
    {

        BiletManager biletManager = new BiletManager(new EfBiletDal());

        public IActionResult Index()
        {
            var b = biletManager.GetAll();
            return View(b);
        }
        public ActionResult DeleteBilet(int id)
        {
            var biletValue = biletManager.GetById(id);
            biletManager.Delete(biletValue);
            return RedirectToAction("Index");
        }

    }
}
