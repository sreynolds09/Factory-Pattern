namespace FactoryPattern;

public class ATV : IVehicle
{
    public void vehicle()
    {
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The car is driving");
        }
    }
}  
