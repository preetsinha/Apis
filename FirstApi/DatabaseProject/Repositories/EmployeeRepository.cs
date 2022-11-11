using DatabaseProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseProject.DatabaseContext;
using DatabaseProject.Models;

namespace DatabaseProject.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly SqlServerContext _SqlServerContext;

        public EmployeeRepository(SqlServerContext sqlServerContext)
        {
            _SqlServerContext = sqlServerContext;
        }

        public List<Employee> GetEmployees()
        {
            var ListEmployees = _SqlServerContext.Employee.ToList();
            return ListEmployees;
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = _SqlServerContext.Employee.FirstOrDefault(x => x.EmpId == id);
            return employee;
        }

        public Employee AddEmployee(Employee employee)
        {
            _SqlServerContext.Employee.Add(employee);
            _SqlServerContext.SaveChanges();
            return employee;
        }

    }
  
}
