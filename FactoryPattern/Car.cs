using System;
namespace FactoryPattern
{

    public class Car : IVehicle
    {
        
        public void vehicle()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The car is driving");
        }
    }
}