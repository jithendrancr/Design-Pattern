using AdapterPattern.Adaptee;
using AdapterPattern.Adapter;
using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager _employeeManager = new EmployeeManager();
            string employeeXml = _employeeManager.GetAllEmployees();
            Console.WriteLine("---------------Printing Direct XML Data-------------------");
            Console.WriteLine("EmpoyeeXml format Data:--> " + employeeXml);
            IEmployee empAdapter = new EmployeeAdapter();
            string empJson = empAdapter.GetAllEmployees();
            Console.WriteLine();
            Console.WriteLine("---------------Printing Direct XML Data Converting into Json through Adapter-------------------");

            Console.WriteLine("EmpoyeeJSON format Data:--> " + empJson);
            Console.ReadLine();


        }
    }
}
