using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class EmployeeSystem
    {
        IComputerFactory _IComputorFactory = null;
        public EmployeeSystem(IComputerFactory icomputerfactory)
        {
            _IComputorFactory = icomputerfactory;
        }
        public string GetSystemDetails()
        {
            IBrand _IBrand = _IComputorFactory.Brand();
            IProcessor _IProcessor = _IComputorFactory.Processor();
            IComputeType _IComputerType = _IComputorFactory.ComputeType();

            string ComputeDetails = "[Brand = " + _IBrand.GetBrand()+ ", Processor = " + _IProcessor.GetProcessor() + ", System Type= " + _IComputerType.GetComputerType()+ "]";
            return ComputeDetails;
        }
    }
}
