using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALUser
{
    public class UserContext:DbContext
    {
        public UserContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=AZ-LKM-DNET-002;Database=UserDb;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        public DbSet<User> tbUser { get; set; }
    }

}
