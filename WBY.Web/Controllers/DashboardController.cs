using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WBY.Web.Controllers
{
    public class DashboardController : Controller
    {
        public DashboardController()
        {
        }

        //
        // GET: /Dashboard/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Overview()
        {
            return PartialView("_Overview");
        }

        public ActionResult Substances()
        {
            return PartialView("_SubstanceProfile");
        }

        public ActionResult Settings()
        {
            return PartialView("_Settings");
        }

        public ActionResult Support()
        {
            return PartialView("_Support");
        }
    }
}
