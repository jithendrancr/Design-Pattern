using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class DesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Dell();
        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public virtual IComputeType ComputeType()
        {
            return new Desktop();
        }
    }
    public class LaptopFactory : DesktopFactory
    {
        public override IComputeType ComputeType()
        {
            return new Laptop();
        }
    }
}
