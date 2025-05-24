using System;
namespace FactoryPattern
{

    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelcount)
        {
            switch (wheelcount)
            {
                case 2: return new Motorcycle();
                case 4: return new Car();
                case 3: return new ATV();
                default: return new Car();
            }

        }
    }
}