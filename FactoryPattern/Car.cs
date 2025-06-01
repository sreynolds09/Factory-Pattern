using System;
namespace FactoryPattern
{

    public class Car : IVehicle
    {
        
        public void Vehicle()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The car is driving");
        }
    }
}