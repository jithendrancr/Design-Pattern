using AbstractFactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory GetFactory(Employee emp)
        {
            if (emp.Designation == "Manager")
            {
                return new LaptopFactory();
            }
            else
            {
                return new DesktopFactory();
            }
        }
    }
}
