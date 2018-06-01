using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.PlatformAbstractions;
using MyFirstApplication.Data.Models;

namespace MyFirstApplication.Data
{
    public class MyFirstApplicationDataContext : DbContext
    {
        private static bool _created;
        public MyFirstApplicationDataContext(DbContextOptions<MyFirstApplicationDataContext> options) : base(options)
        {
         
        }

        public MyFirstApplicationDataContext()
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });
        } 

        public virtual DbSet<User> Users { get; set; }  
        #region DbContext override
          
        #endregion
    }
}