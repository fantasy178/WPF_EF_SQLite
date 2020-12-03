namespace WPF_EF_SQLite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.SQLite.EF6.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WPF_EF_SQLite.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            this.AutomaticMigrationDataLossAllowed = true;
            this.SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(WPF_EF_SQLite.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
