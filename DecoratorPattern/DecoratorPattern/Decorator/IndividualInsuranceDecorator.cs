using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Interface;
using DecoratorPattern.Models;
using DecoratorPattern.Concrete;

namespace DecoratorPattern.Decorator
{
    public class IndividualInsuranceDecorator : InsuranceDecorator
    {
        public IndividualInsuranceDecorator(IEmployee iemployee) : base(iemployee)
        {
        }
        public void AddInsurance(IEmployee emp)
        {
            if (emp is Employee)
            {
                Employee _emp = (Employee)emp;
                _emp.EmployeeDTO.InsuranceDetails = "Individual Medical Insurance";
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
