using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Models
{
    public class Employee
    {
        public int Id{get;set;}

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int EmployeeTypeId { get; set; }
        public decimal SpecialAllowances { get; set; }
        public decimal LTA { get; set; }
        public decimal Bonus { get; set; }
    }
    public class EmployeeType
    {
        public int EmployeeTypeId { get; set; }
        public string EmployeeTypeDesc { get; set; }
    }
}
