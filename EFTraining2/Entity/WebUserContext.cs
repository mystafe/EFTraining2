using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTraining2.Entity
{
    internal class WebUserContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
        string ConnectionString = "server=.;Trusted_Connection=true;Database=WebUser";
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
