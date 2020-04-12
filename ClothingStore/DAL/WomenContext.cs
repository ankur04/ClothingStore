using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;
using ClothingStore.Models;

namespace ClothingStore.DAL
{
    public class WomenContext : DbContext
    {

        public WomenContext() : base("WomenContext")
        {
        }

        public DbSet<Women> WomenSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}