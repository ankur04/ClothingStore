using ClothingStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;

namespace ClothingStore.DAL
{
    public class HatContext : DbContext
    {

        public HatContext() : base("HatContext")
        {
        }

        public DbSet<Hats> HatsSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}