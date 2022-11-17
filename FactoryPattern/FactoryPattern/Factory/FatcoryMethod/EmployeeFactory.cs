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
    public class EmployeeFactory 
    {
        public BaseEmployeeFactory GetEmployee(Employee emp)
        {
            BaseEmployeeFactory FinalEmployee = null;
            switch (emp.EmployeeTypeId)
            {
                case 1:
                    FinalEmployee = new PermanentEmployeeFactory(emp);
                    break;
                case 2:
                    FinalEmployee = new ContractEmployeeFactory(emp);
                    break;
                default:
                    FinalEmployee = new PermanentEmployeeFactory(emp);
                    break;
            }
            return FinalEmployee;
        }
       
    }
}
