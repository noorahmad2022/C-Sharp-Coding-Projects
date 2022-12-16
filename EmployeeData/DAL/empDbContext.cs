using EmployeeData.Models.DbEntities;
using Microsoft.EntityFrameworkCore;
namespace EmployeeData.DAL
{
    public class empDbContext : DbContext
    {
        public empDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> employees { get; set; }
    }
}
