using FactoryPattern.EmployeeTypeClasses;
using FactoryPattern.Interfaces;
using FactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory.FatcoryMethod
{
    class ContractEmployeeFactory:BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }
        public override IEmployee CreateEmployee()
        {
            ContractEmployee obj = new ContractEmployee();
            _emp.LTA = obj.GetLTA();
            return obj;
        }
    }
}
