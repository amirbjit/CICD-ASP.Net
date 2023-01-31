using HRM.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace HRM.API.Db
{
    public class HRMContext
    {
        public HRMContext(DbContextOptions<HRMContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
