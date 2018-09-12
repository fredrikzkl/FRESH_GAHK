using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GAHK.Controllers
{
    public class OpptagelseController : Controller
    {
        // GET: Opptagelse
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Rundvisning()
        {
            return PartialView("_RundvisningForm");
        }

        [HttpGet]
        public ActionResult Fremleje()
        {
            return PartialView("_FremlejeForm");
        }
    }
}