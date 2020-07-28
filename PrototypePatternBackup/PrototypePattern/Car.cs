namespace PrototypePattern
{
    internal class Car
    {
        private string carName;

        public Car(string name)
        {
            this.carName = name;
        }

        internal string getName()
        {
            return carName;
        }

        internal void setName(string name)
        {
            this.carName = name;
        }
    }
}