using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AmazingRace.Models;

namespace AmazingRace.DAL
{
    public class AmazingRaceInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AmazingRaceContext>
    {
        protected override void Seed(AmazingRaceContext context)
        {
            var staffs = new List<Staff>
            {
                new Staff{EmailID="xyz@u.nus.edu",Password="area1234",StaffID=1234,StaffName="remo"},
                new Staff{EmailID="abc@u.nus.edu",Password="area2345",StaffID=3456,StaffName="rome"}
            };
            staffs.ForEach(s => context.Staffs.Add(s));
            context.SaveChanges();
        }
    }
}