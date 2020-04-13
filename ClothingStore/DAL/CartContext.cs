using System;
using System.Collections.Generic;
using System.Linq;
using ClothingStore.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;

namespace ClothingStore.DAL
{
    public class CartContext : DbContext
    {

        public CartContext() : base("CartContext")
        {
        }

        public DbSet<Cart> CartSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}