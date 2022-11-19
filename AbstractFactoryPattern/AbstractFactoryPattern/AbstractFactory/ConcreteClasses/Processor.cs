using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    class I3:IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processors.I3.ToString();
        }
    }
    class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processors.I5.ToString();
        }
    }
    class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processors.I7.ToString();
        }
    }
}
