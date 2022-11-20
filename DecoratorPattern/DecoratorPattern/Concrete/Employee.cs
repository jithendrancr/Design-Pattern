using DecoratorPattern.Interface;
using DecoratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Concrete
{
    public class Employee : IEmployee
    {
        public Employee()
        {
            EmployeeDTO = new EmployeeDTO() {
                EmployeeId = 1,
                FirstName = "Anil",
                LastName = "K",
                Salary = 1200000
            };
        }
        public EmployeeDTO EmployeeDTO { get; set; }

        public EmployeeDTO _EmployeeDTO
        {
            get
            {
                return EmployeeDTO;
            }

            //set
            //{
            //    throw new NotImplementedException();
            //}
        }

        public IEmployee GetEmployee()
        {
            return this;
        }
    }
}
