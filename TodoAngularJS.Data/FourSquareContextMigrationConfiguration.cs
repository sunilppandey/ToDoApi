using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAngularJS.Data.Entities;

namespace TodoAngularJS.Data
{
    class FourSquareContextMigrationConfiguration : DbMigrationsConfiguration<FourSquareContext>
    {
        public FourSquareContextMigrationConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FourSquareContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new FourSquareContext()));

            var user = new ApplicationUser()
            {
                UserName = "SuperPowerUser",
                Email = "sunilppandey@gmail.com",
                EmailConfirmed = true,
                FirstName = "Sunil",
                LastName = "Pandey",
                Level = 1,
                JoinDate = DateTime.Now.AddYears(-3)
            };

            manager.Create(user, "Password@123");
        }
    }
}
