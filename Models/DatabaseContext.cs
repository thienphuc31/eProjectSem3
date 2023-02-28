using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eProject1
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Bell> Bells { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeEvent> EmployeeEvents { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<News> News { get; set; }

        










    }
}
