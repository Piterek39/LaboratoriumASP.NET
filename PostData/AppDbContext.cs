using PostData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostData
{
    public class AppDbContext : DbContext
    {
        public DbSet<PostEntity> Posts { get; set; }
        //public DbSet Contacts { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "posts.db");
            //DbPath = System.IO.Path.Join(path, "contacts.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostEntity>().HasData(
                new PostEntity() { Id = 1, Content = "Pierwszy post", Autor = "adam@wsei.edu.pl", PostDate = new DateTime(2000, 10, 10), Tag="#pierwszypost", Comment="ciekawy post" },
                new PostEntity() { Id = 2, Content = "Drugi post", Autor = "elon@wsei.edu.pl", PostDate = new DateTime(2000, 10, 10), Tag = "#drugipost", Comment = "nudny post" }
            );
        }
    }
}
