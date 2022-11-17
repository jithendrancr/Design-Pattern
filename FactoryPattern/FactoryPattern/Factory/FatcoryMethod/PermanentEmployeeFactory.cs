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
    class PermanentEmployeeFactory :BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp):base(emp)
        {
        }
        public override IEmployee CreateEmployee()
        {
            PermanentEmployee obj = new PermanentEmployee();
            _emp.Bonus = obj.GetBonus();
            return obj;
        }
    }
}
