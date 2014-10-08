using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WBY.Servicess.Home;

namespace WBY.Web.Controllers
{
    public class HomeController : Controller
    {
        private IHomeService _homeService;

        public HomeController() : this(new HomeService())
        {
            
        }

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public ActionResult Index()
        {
            var indexModel = _homeService.GetModelForIndex();
            return View(indexModel);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
