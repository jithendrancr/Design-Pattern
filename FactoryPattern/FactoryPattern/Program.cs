using FactoryPattern.Factory.FatcoryMethod;
using FactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeType> empTypes = new List<EmployeeType>()
            {
            new EmployeeType {EmployeeTypeId = 1,EmployeeTypeDesc = "Permanent"},
            new EmployeeType{ EmployeeTypeId = 2,EmployeeTypeDesc = "Contact"}
            };
            Employee emp = new Employee()
            {
                Id = 1,
                Name = "Anil",
                Salary = 1200000,
                EmployeeTypeId = 1
            };

            BaseEmployeeFactory empFactory = new EmployeeFactory().GetEmployee(emp);
            emp = empFactory.ApplyBenefits();

            Console.WriteLine("--------Permanent Employee Has No LTA but Has Bonus--------------");
            Console.WriteLine(
                "Permanent Emp Details--> "  
                +Environment.NewLine + " Name = " + emp.Name
                +Environment.NewLine + " Salary = " + emp.Salary
                + Environment.NewLine + " Special Allowances =  " + emp.SpecialAllowances
                + Environment.NewLine + " Bonus =  " + emp.Bonus
                + Environment.NewLine + " LTA =  " + emp.LTA
                );
            Employee emp1 = new Employee()
            {
                Id = 2,
                Name = "Sunil",
                Salary = 1300000,
                EmployeeTypeId = 2
            };

            
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("--------Cotract Employee Has No Bonus But has LTA--------------");

            empFactory = new EmployeeFactory().GetEmployee(emp1);
            emp = empFactory.ApplyBenefits();
            Console.WriteLine(
                "Contract Emp Details--> "
                + Environment.NewLine + " Name = " + emp.Name
                + Environment.NewLine + " Salary = " + emp.Salary
                + Environment.NewLine + " Special Allowances =  " + emp.SpecialAllowances
                + Environment.NewLine + " Bonus =  " + emp.Bonus
                + Environment.NewLine + " LTA =  " + emp.LTA
                );

            Console.ReadLine();

        }
    }
}
