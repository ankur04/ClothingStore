using ClothingStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;

namespace ClothingStore.DAL
{
    public class JacketContext : DbContext
    {

        public JacketContext() : base("JacketContext")
        {
        }

        public DbSet<Jackets> JacketsSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}