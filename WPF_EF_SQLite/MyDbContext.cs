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
        public DbSet<Axis> Axes { get; set; }

        public MyDbContext(string dbPath) : base(new SQLiteConnection() { ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = dbPath, ForeignKeys = true }.ConnectionString }, true)
        {
        }
    }
}
