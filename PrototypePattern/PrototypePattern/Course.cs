namespace PrototypePattern
{
    internal class Course
    {
        private string Name;
        private string ID;

        public Course(string name, string id)
        {
            this.Name = name;
            this.ID = id;
        }

        internal string getName()
        {
            return Name;
        }

        internal void setName(string name)
        {
            this.Name = name;
        }

        internal string getID()
        {
            return ID;
        }

        internal void setID(string id)
        {
            this.ID = id;
        }
    }
}