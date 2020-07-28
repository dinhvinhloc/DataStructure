using System;

namespace FactoryPattern
{
    internal class VehicleFactory
    {
        internal Car GetVehicle(string v)
        {
            if (v.Equals("Corolla"))
            {
                return new Corolla();
            }
            else
            {
                return new Camry();
            }
        }
    }
}