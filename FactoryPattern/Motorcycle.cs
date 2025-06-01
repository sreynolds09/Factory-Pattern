namespace FactoryPattern;

public class Motorcycle : IVehicle
{
    public void Vehicle()
    {
        ConsoleLogger.VehicleStartUpDialogue();
        Console.WriteLine("The Motorcycle has 2 tires.");
        
        
    }
}