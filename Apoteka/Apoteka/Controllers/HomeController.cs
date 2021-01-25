using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apoteka.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

         [HttpGet]
       public ActionResult KontaktForma ()
        {
            return View();
        }

       [HttpPost]
       public ViewResult KontaktForma(Models.kontakt odgovor)
       {
           return View("Odgovor", odgovor);
       }

       [HttpGet]
       public ActionResult FormaAnketa()
       {
           return View();
       }
       [HttpPost]
       public ViewResult FormaAnketa(Models.anketa odgovor2)
       {
           return View("Odgovor2", odgovor2);
       }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
 
    }
}