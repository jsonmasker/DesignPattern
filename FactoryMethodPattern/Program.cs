using FactoryMethodPattern.Factory;
using FactoryMethodPattern.Products;

namespace FactoryMethodPattern
{
    internal class Program
    {
        /// <summary>
        /// The factory method pattern is a creational pattern that uses factory methods to deal with the problem of creating objects without specifying the exact class of object that will be created.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Use CarFactory
            VehicleFactory carFactory = new CarFactory();
            IVehicle car = carFactory.CreateVehicle();
            car.Drive();

            // Use BikeFactory
            VehicleFactory bikeFactory = new BikeFactory();
            IVehicle bike = bikeFactory.CreateVehicle();
            bike.Drive();

            Console.ReadLine();
        }
    }
}
