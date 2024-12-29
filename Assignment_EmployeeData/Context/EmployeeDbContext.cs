using Assignment_EmployeeData.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Assignment_EmployeeData.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
        { }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }

}
