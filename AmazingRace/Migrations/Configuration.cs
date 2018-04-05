namespace AmazingRace.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AmazingRace.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AmazingRace.DAL.AmazingRaceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AmazingRace.DAL.AmazingRaceContext";
        }

        protected override void Seed(AmazingRace.DAL.AmazingRaceContext context)
        {
            var staffs = new List<Staff>
            {
                new Staff{EmailID="xyz@u.nus.edu",Password="area1234",StaffID=1234,StaffName="remo",ConfirmPassword="area1234"},
                new Staff{EmailID="abc@u.nus.edu",Password="area2345",StaffID=3456,StaffName="rome",ConfirmPassword="area2345"}
            };
            staffs.ForEach(s => context.Staffs.Add(s));
            context.SaveChanges();
        }
    }
}
