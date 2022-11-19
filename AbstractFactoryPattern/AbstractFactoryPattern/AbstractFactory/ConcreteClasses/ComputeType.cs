using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class Desktop: IComputeType
    {

        public string GetComputerType()
        {
            return Enumerations.ComputerTypes.Desktop.ToString();
        }
    }
    public class Laptop : IComputeType
    {
        public string GetComputerType()
        {
            return Enumerations.ComputerTypes.Laptop.ToString();
        }
    }
}
