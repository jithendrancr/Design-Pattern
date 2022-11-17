using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.EmployeeTypeClasses
{
    class ContractEmployee : IEmployee
    {
        public decimal GetSpecialAllowances()
        {
            return 12000;
        }
        public decimal GetLTA()
        {
            return 17000;
        }
    }
}
