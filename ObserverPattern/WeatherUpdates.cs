using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherUpdates
    {
        private float _Temparature = 0f;
        private float _WindSpeedKmph = 0;
        public float Temparature { 
            get => _Temparature ; 
            set { 
                if (_Temparature != value) {
                    _Temparature = value;
                    Notify(); 
                }
            } 
        }
        public float WindSpeed { get=>_WindSpeedKmph; set { if (_WindSpeedKmph != value) { _WindSpeedKmph = value;Notify(); } } }
        private List<ICustomer> _observers = new List<ICustomer>();
        public WeatherUpdates(float temparature, float windSpeedKmph)
        {
            _Temparature = temparature;
            _WindSpeedKmph = windSpeedKmph;
        }
        public void AddCustomer(ICustomer customer)
        { 
            _observers.Add(customer);
        }
        public void RemoveCustomer(ICustomer customer)
        { 
            _observers.Remove(customer);
        }
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
