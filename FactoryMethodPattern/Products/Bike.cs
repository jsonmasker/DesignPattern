using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Products
{
    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a bike");
        }
    }
}
