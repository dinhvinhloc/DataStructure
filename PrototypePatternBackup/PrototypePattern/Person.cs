using System;

namespace PrototypePattern
{
    internal class Person : ICloneable
    {
        public string Name { get; set; }
        private Car car;

        public Person(string name, string carName)
        {
            this.Name = name;
            this.car = new Car(carName);
        }
        internal string getName() {
            return Name;
        }


        internal Person Clone() //Shallow copy
        {
            return (Person)base.MemberwiseClone();
        }

        internal Car getCar()
        {
            return car;
        }

        object ICloneable.Clone() //Shallow copy
        {
            return base.MemberwiseClone();
        }


        internal Person DeepCopy() //Deep copy
        {
            Person temp = (Person)base.MemberwiseClone();
            temp.car = new Car(car.getName());
            return temp;
        }
    }
}