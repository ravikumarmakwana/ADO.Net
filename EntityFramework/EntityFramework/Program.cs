using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework
{
    public class EmployeeRepository
    {
        public List<Department> GetDepartments()
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            return employeeDBContext.Departments.ToList();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
