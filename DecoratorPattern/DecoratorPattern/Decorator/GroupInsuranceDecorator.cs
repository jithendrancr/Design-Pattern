using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Interface;
using DecoratorPattern.Concrete;

namespace DecoratorPattern.Decorator
{
    public class GroupInsuranceDecorator : InsuranceDecorator
    {
        public GroupInsuranceDecorator(IEmployee iemployee) : base(iemployee)
        {
        }
        public void AddInsurance(IEmployee emp)
        {
            if(emp is Employee)
            {
                Employee _employee = (Employee)emp;
                _employee.EmployeeDTO.InsuranceDetails = "Group Medical Insurance";
            }
        }
        public override IEmployee GetEmployee()
        {
            _IEmployee.GetEmployee();
            AddInsurance(_IEmployee);
            return _IEmployee;
        }
    }
}
