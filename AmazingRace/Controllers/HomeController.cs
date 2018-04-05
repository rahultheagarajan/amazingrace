using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmazingRace.DAL;

namespace AmazingRace.Controllers
{
    public class HomeController : Controller
    {
        private AmazingRaceContext db = new AmazingRaceContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }
        
    }
}