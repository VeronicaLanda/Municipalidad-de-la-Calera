using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MunicipalidaddelaCalera.Controllers
{
    public class NoticiasController : Controller
    {
        // GET: Noticias
        public ActionResult Vivienda()
        {
            return View();
        }

        public ActionResult Convenios()
{
    return View();
}
        public ActionResult Obras()
        {
            return View();
        }
    }
}