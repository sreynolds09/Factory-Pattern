namespace FactoryPattern;

public class ATV : IVehicle
{
    public void Vehicle()
    {
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The car is driving");
        }
    }
}  
