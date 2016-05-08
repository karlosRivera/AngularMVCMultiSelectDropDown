using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{

    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Countries = GetCountries();
            return View();
        }

        public ActionResult MultiSelectCountry()
        {
            ViewBag.Countries = GetCountries();
            return View();
        }

        [NonAction]
        public JsonResult GetCountries()
        {
            List<Country> oList = new List<Country>()
           {
                new Country {ID=1,Name="United Kingdom"},
                new Country {ID=1,Name="United States"},
                new Country {ID=1,Name="Italy"},
                new Country {ID=1,Name="Germany"},
                new Country {ID=1,Name="India"}
           };
            return Json(oList);
        }

        //public JsonResult GetCountries()
        //{
        //    List<Country> oList = new List<Country>()
        //   {
        //        new Country {ID=1,Name="United Kingdom"},
        //        new Country {ID=1,Name="United States"},
        //        new Country {ID=1,Name="Italy"},
        //        new Country {ID=1,Name="Germany"},
        //        new Country {ID=1,Name="India"}
        //   };
        //    return Json(oList);
        //}
    }
}
