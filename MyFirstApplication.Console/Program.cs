using System;
using System.Linq;
using MyFirstApplication.Data;
using MyFirstApplication.Data.Models;

namespace MyFirstApplication.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContextFactory factory = new DataContextFactory();

            using (var db = factory.CreateDbContext(null))
            {
                User user = new User()
                {
                    Email = "ciccio2@email.it",
                    Name = "ciccio",
                    Surname = "pasticcio"
                };

                db.Users.Add(user);
                db.SaveChanges();
                var list = db.Users.ToList();
                System.Console.ReadLine();
            } 
        }
    }
}
