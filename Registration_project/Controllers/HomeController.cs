using Registration_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Registration_project.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public void Contact()
        {
           
        }
        public ActionResult Index2()
        {
            int selectedIndex = 1;
            SelectList carBrands = new SelectList(db.CarBrands, "Id", "Name", selectedIndex);
            ViewBag.CarBrands = carBrands;
            SelectList carModels = new SelectList(db.CarModels, "Name", "Name", 1);
            ViewBag.CarModels1 = carModels.Count();
            return View();
            
        }
        public ActionResult GetItems(int id)
        {
            return PartialView(db.CarModels.Where(c => c.BrandId == id).ToList());
        }
    }
}