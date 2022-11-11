using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string ? EmpName { get; set; }
        public string ? City { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int Salary { get; set; }
    }
}
