using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmazingRace.DAL;
using AmazingRace.Models;

namespace AmazingRace.Controllers
{
    public class StaffController : Controller
    {
        private AmazingRaceContext db = new AmazingRaceContext();
    
        
        public ActionResult StaffHomePage(Staff staff)
        {

          var myUser = db.Staffs
         .FirstOrDefault(u => u.EmailID == staff.EmailID
                      && u.Password == staff.Password);

            if (myUser != null)   
            {
                return View();
            }

            else
            {
                return RedirectToAction("Error");
            }
            
        

        }
    }
}