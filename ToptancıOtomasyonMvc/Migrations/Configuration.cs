using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace ToptancıOtomasyonMvc.Migrations
{
    public class Configuration
    {

        internal sealed class Configuration : DbMigrationsConfiguration<DAL.UrunContext>
        {
            public Configuration()
            {
                AutomaticMigrationsEnabled = true;
                AutomaticMigrationDataLossAllowed = true;
            }

            protected override void Seed(ToptancıOtomasyonMvc.DAL.UrunContext context)
            {
                //  This method will be called after migrating to the latest version.

                //  You can use the DbSet<T>.AddOrUpdate() helper extension method
                //  to avoid creating duplicate seed data.
            }
        }
    }
}