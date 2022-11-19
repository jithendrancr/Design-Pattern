using AdapterPattern.Adaptee;
using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml;

namespace AdapterPattern.Adapter
{
    public class EmployeeAdapter :EmployeeManager,IEmployee
    {
        public override string GetAllEmployees()
        {
            string Empxmlstr = base.GetAllEmployees();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(Empxmlstr);
            return JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
