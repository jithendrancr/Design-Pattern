using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Models;

namespace DecoratorPattern.Decorator
{
    public abstract class InsuranceDecorator : IEmployee
    {
        protected IEmployee _IEmployee;
        public InsuranceDecorator(IEmployee iemployee)
        {
            _IEmployee = iemployee;
        }

        public EmployeeDTO _EmployeeDTO
        {
            get
            {
                return _IEmployee._EmployeeDTO;
            }
        }

        public virtual IEmployee GetEmployee()
        {
            return _IEmployee.GetEmployee();
        }
    }
}
