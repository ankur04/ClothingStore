using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using ClothingStore.Models;

namespace ClothingStore.DAL
{
    public class UserContext : DbContext
    {

        public UserContext() : base("UserContext")
        {
        }

        public DbSet<Models.UserEntity> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}