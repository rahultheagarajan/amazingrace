using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmazingRace.DAL;
using AmazingRace.Models;
using System.Net;
using System.Net.Mail;

namespace AmazingRace.Controllers
{
    public class HomeController : Controller
    {
        private AmazingRaceContext db = new AmazingRaceContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Staff());
        }

        [HttpPost]
        public ActionResult Index(Staff staff)
        {
            return View(staff);
        }


        [HttpGet]
        public ActionResult SignUp()
        {
            return View(new Staff());
        }

        [HttpPost]
        public ActionResult SignUp(Staff staff)
        {
            db.Staffs.Add(staff);
            db.SaveChanges();
            SendActivationEmail(staff);
            return View("Success");

        }

        private void SendActivationEmail(object user)
        {
           
}
    }
}