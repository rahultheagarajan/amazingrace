using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using AmazingRace.Models;

namespace AmazingRace.DAL
{
    public class AmazingRaceContext : DbContext
    {
        public AmazingRaceContext() : base("AmazingRaceContext")
        {

        }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<UserActiviation> UserActivations { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}