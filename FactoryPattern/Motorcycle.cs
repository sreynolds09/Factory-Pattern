namespace FactoryPattern;

public class Motorcycle : IVehicle
{
    public void vehicle()
    {
        ConsoleLogger.VehicleStartUpDialogue();
        Console.WriteLine("The Motorcycle has 2 tires.");
        
        
    }
}