using Employee.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DAL.Data
{
   public class EmployeeDBContext: DbContext
    {



        
            public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
            {



            }



            public DbSet<Employeee> Employees { get; set; }



            /*protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
            }*/
        }
    }










