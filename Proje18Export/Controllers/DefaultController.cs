using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje18Export.Models.Entity;


namespace Proje18Export.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        MvcDBStokEntities db = new MvcDBStokEntities();
        public ActionResult Index()
        {
            var degerler=db.TBLURUNLER.ToList();
            return View(degerler);
        }
    }
}