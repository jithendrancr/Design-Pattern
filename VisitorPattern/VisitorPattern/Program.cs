using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IStore> store = new List<IStore>();
            store.Add(new Car() { CarName = "A1", Price = 90000000M, CarType = "Mercedes" });
            store.Add(new Car() { CarName = "A2", Price = 1000000M, CarType = "Normal" });

            store.Add(new Bike() { BikeName = "B1", Price = 50M, BikeType = "Bullet" });
            store.Add(new Bike() { BikeName = "B2", Price = 30M, BikeType = "Normal" });

            PriceVisitor priceVisitor = new PriceVisitor();
            foreach (var element in store)
            {
                element.Visit(priceVisitor);
            }

            WeightVisitor weightVisitor = new WeightVisitor();
            foreach (var element in store)
            {
                element.Visit(weightVisitor);
            }

            Console.ReadLine();
        }
    }
}
