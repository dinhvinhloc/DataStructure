namespace FactoryLab
{
    internal class Creator
    {
        internal IShape FactoryMethod(string v, double specifications)
        {
            if (v.Equals("Rectangle"))
            {
                return new Rectangle(specifications);
            } else if (v.Equals("Circle"))
            {
                return new Circle(specifications);
            }
            else
            {
                return new Triangle(specifications);
            }
        }
        internal IShape FactoryMethod(string v, double[] specifications)
        {
            if (v.Equals("Rectangle"))
            {
                return new Rectangle(specifications);
            }
            else if (v.Equals("Circle"))
            {
                return new Circle(specifications);
            }
            else
            {
                return new Triangle(specifications);
            }
        }
    }
}