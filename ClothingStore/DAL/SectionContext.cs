using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;
using ClothingStore.Models;

namespace ClothingStore.DAL
{
    public class SectionContext : DbContext
    {

        public SectionContext() : base("SectionContext")
        {
        }

        public DbSet<Section> Sections{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}