using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GAHK.Controllers
{
    public class KollegielivetController : Controller
    {
        // GET: Kollegieliv
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alumnerne()
        {
            return View();
        }
    }
}