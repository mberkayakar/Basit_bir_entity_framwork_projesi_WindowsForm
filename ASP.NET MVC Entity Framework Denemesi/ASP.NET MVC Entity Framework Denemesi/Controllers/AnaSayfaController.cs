using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ASP.NET_MVC_Entity_Framework_Denemesi.Models.siniflar;

namespace ASP.NET_MVC_Entity_Framework_Denemesi.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        public ActionResult Index()
        {
            Context c = new Context();
            var degerler = c.Yeteneklers.ToList();

            return View(degerler);
        }
    }
}