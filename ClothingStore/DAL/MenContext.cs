using ClothingStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;

namespace ClothingStore.DAL
{
    public class MenContext : DbContext
    {

        public MenContext() : base("MenContext")
        {
        }

        public DbSet<Men> MenSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}