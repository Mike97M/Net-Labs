namespace Lab5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class eConfiguration : DbMigrationsConfiguration<Lab5.BusinessContext>
    {
        public eConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }
       

        protected override void Seed(Lab5.BusinessContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
