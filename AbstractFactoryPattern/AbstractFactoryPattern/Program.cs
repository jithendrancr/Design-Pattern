using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lstEmp = new List<Employee>{
            new Employee{Id = 1,Name="Anil",Designation = "Manager"},
            new Employee{Id = 2, Name= "Sunil", Designation = "TL"}
            };
            IComputerFactory ComFactory = null;
            
            foreach (var item in lstEmp)
            {
                ComFactory = new EmployeeSystemFactory().GetFactory(item);
                EmployeeSystem empSystem = new EmployeeSystem(ComFactory);
                item.SystemDetails = empSystem.GetSystemDetails();
                Console.WriteLine(
                    "Employee Name : " + item.Name + 
                    Environment.NewLine + "Designation " + item.Designation + 
                    Environment.NewLine + "System Details : " + item.SystemDetails
                    );
            }
            Console.ReadLine();
        }
    }
}
