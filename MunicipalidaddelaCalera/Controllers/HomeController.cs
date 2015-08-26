using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MunicipalidaddelaCalera.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contacto()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Archivos()
        {
            ViewBag.Message = "Your Archivos page.";

            return View();
        }
        public ActionResult GaleriadeFotos()
        {
            ViewBag.Message = "Your Galeria de fotos page.";

            return View();
        }

        public ActionResult Deporte()
        {
            ViewBag.Message = "Your Deporte page.";

            return View();
        }
        public ActionResult Viviendas()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Post()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}