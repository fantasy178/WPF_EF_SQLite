using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_EF_SQLite
{
    class MyDbContext : DbContext
    {
        private static readonly bool[] s_migrated = { false };
        private static string path;
        public DbSet<Axis> Axes { get; set; }

        public MyDbContext() : base(new SQLiteConnection() { ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = path }.ConnectionString }, true)
        {
        }
        public MyDbContext(string dbPath) : base(new SQLiteConnection() { ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = dbPath }.ConnectionString }, true)
        {
            path = dbPath;
            Migrate();
        }
        private static void Migrate()
        {
            if (!s_migrated[0])
            {
                lock (s_migrated)
                {
                    if (!s_migrated[0])
                    {
                        Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyDbContext, Configuration>());
                        s_migrated[0] = true;
                    }
                }
            }
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
