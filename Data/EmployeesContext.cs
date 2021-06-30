using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employees.Models;

namespace Employees.Data
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext (DbContextOptions<EmployeesContext> options)
            : base(options)
        {
        }

        public DbSet<Employees.Models.EmployeeInfo> EmployeeInfo { get; set; }
    }
}
