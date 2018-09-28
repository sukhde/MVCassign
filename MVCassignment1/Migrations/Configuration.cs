namespace MVCassignment1.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MVCassignment1.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCassignment1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVCassignment1.Models.ApplicationDbContext context)
        {
           
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            ApplicationUser adminUser = null;

                adminUser = new ApplicationUser();
                adminUser.UserName = "admin@mynew.com";
                adminUser.Email = "admin@mynew.com";
 
                userManager.Create(adminUser, "MYnewadmin1!");
            
        }
    }
}
