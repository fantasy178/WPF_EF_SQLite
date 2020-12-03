using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.CodeFirst;
using WPF_EF_SQLite.Migrations;

namespace WPF_EF_SQLite
{
    class MyDbContext : DbContext
    {
        public DbSet<Axis> Axes { get; set; }
                
        public MyDbContext(string dbPath) : base(
            new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder()
                {
                    DataSource = dbPath
                }.ConnectionString }, 
            true)
        {
            Database.CreateIfNotExists();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var initializer = new SqliteDropCreateDatabaseWhenModelChanges<MyDbContext>(modelBuilder);
            Database.SetInitializer(initializer);
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
