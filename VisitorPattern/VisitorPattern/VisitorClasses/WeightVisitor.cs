using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class WeightVisitor : IVisitor
    {
        public void Accept(Car car)
        {
            switch (car.CarType)
            {
                case "Mercedes":
                    Console.WriteLine("Car {0} weight: {1} KG", car.CarName, 1750);
                    break;
                case "Normal":
                    Console.WriteLine("Car {0} weight: {1} KG", car.CarName, 750);
                    break;
            }
        }

        public void Accept(Bike bike)
        {
            switch (bike.BikeType)
            {
                case "Bullet":
                    Console.WriteLine("Bike {0} weight: {1} KG", bike.BikeName, 300);
                    break;
                case "Normal":
                    Console.WriteLine("Bike {0} weight: {1} KG", bike.BikeName, 100);
                    break;
            }
        }
    }
}
