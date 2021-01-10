using System;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMVC.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
