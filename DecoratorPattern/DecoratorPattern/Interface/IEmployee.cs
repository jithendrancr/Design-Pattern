using DecoratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Interface
{
    public interface IEmployee
    {
        IEmployee GetEmployee();
        EmployeeDTO _EmployeeDTO { get; }
    }
}
