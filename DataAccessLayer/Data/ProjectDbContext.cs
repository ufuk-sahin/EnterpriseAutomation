using DataAccessLayer.Entities.Concrete.Employee;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
              : base(options)
        {
        }

    }
}
