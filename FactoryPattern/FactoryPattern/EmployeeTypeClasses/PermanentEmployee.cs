using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.EmployeeTypeClasses
{
    class PermanentEmployee : IEmployee
    {
        public decimal GetSpecialAllowances()
        {
            return 10000;
        }
        public decimal GetBonus()
        {
            return 5000;
        }
    }
}
