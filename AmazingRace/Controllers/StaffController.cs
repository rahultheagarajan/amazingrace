using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmazingRace.DAL;

namespace AmazingRace.Controllers
{
    public class StaffController : Controller
    {
        private AmazingRaceContext db = new AmazingRaceContext();
        public ActionResult StaffHomePage()
        {
            if
             {
                var signin = from b in db.Staffs
                             where b.EmailID.Equals(EmailID);



                             return View();
            }
            else
            {
                
            }
            
        

        }
    }
}