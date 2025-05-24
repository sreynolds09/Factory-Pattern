namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int wheelcount;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amount of tires for the vehicle that you want to create.");
                input = int.TryParse(Console.ReadLine(), out wheelcount);

            } while (input == false);
            
            var vehicle = VehicleFactory.GetVehicle(wheelcount);
            vehicle.vehicle();
        }
    }
}
