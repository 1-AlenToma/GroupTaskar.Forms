using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;


namespace GroupTaskar.Core
{
    public class Context : DbContext
    {
        public DbSet<TasksItem> TasksItems { get; set; }

        public DbSet<Item> Items { get; set; }

        public string DbPath { get; }

        public Context()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "TaskGrouper.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");


    }
}
