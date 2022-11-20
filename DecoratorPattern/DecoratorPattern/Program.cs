using DecoratorPattern.Concrete;
using DecoratorPattern.Interface;
using DecoratorPattern.Decorator;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee = new Employee();
            employee.GetEmployee();
            Console.WriteLine("Basic Employee Details: " + JsonConvert.SerializeObject(employee._EmployeeDTO));
            Console.WriteLine();

            IndividualInsuranceDecorator Individualemployee = new IndividualInsuranceDecorator(employee);
            Individualemployee.GetEmployee();
            Console.WriteLine("Employee Details with Individual Insurance: " + JsonConvert.SerializeObject(Individualemployee._EmployeeDTO));
            Console.WriteLine();

            GroupInsuranceDecorator Groupemployee = new GroupInsuranceDecorator(employee);
            Groupemployee.GetEmployee();
            Console.WriteLine("Employee Details with Group Insurance: " + JsonConvert.SerializeObject(Groupemployee._EmployeeDTO));

            Console.ReadLine();
        }
    }
}
