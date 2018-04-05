namespace AmazingRace.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AmazingRace.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<AmazingRace.DAL.AmazingRaceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AmazingRace.DAL.AmazingRaceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

      
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
}
