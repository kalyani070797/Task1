using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarkiz_Task1.Infrastructure.Tables;

namespace Tarkiz_Task1.Infrastructure.PracticeDBContext
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) 
        {
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Payment> Payment { get; set; }
    }
}
