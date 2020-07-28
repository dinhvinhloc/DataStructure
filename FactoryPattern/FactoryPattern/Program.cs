using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vFactory = new VehicleFactory();
            Car c = vFactory.GetVehicle("Corolla");
            Console.WriteLine(c.GetCarInfo());
        }
    }
}
