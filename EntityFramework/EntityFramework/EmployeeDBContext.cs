using System.Data.Entity;

namespace EntityFramework
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; } 
    }
}
