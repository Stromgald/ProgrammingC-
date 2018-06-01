using System; 
using System.IO; 
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.PlatformAbstractions;

namespace MyFirstApplication.Data
{
    public class DataContextFactory : IDesignTimeDbContextFactory<MyFirstApplicationDataContext>
    {  

        public MyFirstApplicationDataContext CreateDbContext(string[] args)
        { 

            var path = PlatformServices.Default.Application.ApplicationBasePath;
            var connection = $"Data source={Path.Combine(path, "Database.db")}";
           
            var optionsBuilder = new DbContextOptionsBuilder<MyFirstApplicationDataContext>(); 
            optionsBuilder.UseSqlite(connection);

            return new MyFirstApplicationDataContext(optionsBuilder.Options);
        }
    }

}
