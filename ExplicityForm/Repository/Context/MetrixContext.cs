﻿using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using DataLayer.DatabaseData;

namespace Repository
{
    public class MetrixContext : DbContext
    {
        public DbSet<ComputerDetail> ComputerDetails { get; set; }
        public DbSet<UsageData> UsageDatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "metrics.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);
            optionsBuilder.UseSqlite(connection);          
        }
    }
}
