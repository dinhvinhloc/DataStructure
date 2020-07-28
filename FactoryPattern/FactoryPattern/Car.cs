using System;

namespace FactoryPattern
{
    internal class Car
    {
        private string vin;

        public string VIN 
        {
            get { return vin; } 
            set { vin = value; }
        }

        internal string GetCarInfo()
        {
            return this.VIN;
        }
    }
}