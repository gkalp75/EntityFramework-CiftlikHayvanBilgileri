using HayvanBakımıDb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBakımıDb.Context
{
    internal class HayvanBakımDb : DbContext
    {
        public DbSet<Hayvan> Hayvanlar { get; set; }
        public DbSet<Sahip> Sahipler { get; set; }
        public DbSet<Bakici> Bakicilar { get; set; }
        public DbSet<Yiyecek> Yiyecekler { get; set; }

 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data source=.;initial catalog=HayvanDB;integrated security=true");
        }

        //FluentAPI
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Hayvan>().Property(x => x.Ad).HasMaxLength(40);
        //    modelBuilder.Entity<Sahip>().Property(x => x.Ad).HasMaxLength(40);
        //    modelBuilder.Entity<Bakici>().Property(x => x.Ad).HasMaxLength(40);
        //    modelBuilder.Entity<Yiyecek>().Property(x => x.YiyecekAdi).HasMaxLength(40);
        //}
    }
}
