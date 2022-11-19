using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory
{
    public class Apple:IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brands.APPLE.ToString();
        }
    }
    public class Dell : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brands.DELL.ToString();
        }
    }

}
