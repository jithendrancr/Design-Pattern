using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Customer : ICustomer
    {
        public string CustomerName { get; set; }
        public Customer(string customerName)
        {
            CustomerName = customerName;
        }

        public void Update(WeatherUpdates weather)
        {
            Console.WriteLine($"Weather Update for {CustomerName} is Temparature: {weather.Temparature.ToString()} And WindSpeed is : {weather.WindSpeed.ToString()}/KM at: {DateTime.Now.ToString()}");
        }
    }
}
