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
    public class SeferController : Controller
    {       
        SeferManager seferManager = new SeferManager(new EfSeferDal());
        public IActionResult Index()
        {
            var sefer = seferManager.GetAll();
            return View(sefer);
        }
        [HttpGet]
        public ActionResult AddSefer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSefer(Sefer sefer)
        {
            seferManager.Add(sefer);
            return RedirectToAction("Index");
        }       
        [HttpGet]
        public ActionResult UpdateSefer(int id)
        {
            var seferValue = seferManager.GetById(id);
            return View(seferValue);
        }
        [HttpPost]
        public ActionResult UpdateSefer(Sefer sefer)
        {
            seferManager.Update(sefer);
            return RedirectToAction("Index");
        }
    }
}
