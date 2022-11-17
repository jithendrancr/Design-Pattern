using FactoryPattern.Interfaces;
using FactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.FatcoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory (Employee emp)
	    {
            _emp = emp;
	    }
        public Employee ApplyBenefits()
        {
            IEmployee employee = this.CreateEmployee();
            _emp.SpecialAllowances = employee.GetSpecialAllowances();
            return _emp;
        }
        public abstract IEmployee CreateEmployee();
        
    }
}
