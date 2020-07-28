namespace FactoryLab
{
    internal class Rectangle : IShape
    {
        private double height = 1;
        private double length = 1;

        public Rectangle()
        {
        }

        public Rectangle(double specifications)
        {
            this.length = specifications;
        }

        public Rectangle(double[] specifications)
        {
            this.height = specifications[0];
            this.length = specifications[1];
        }


        public double GetArea()
        {
            return height * length;
        }

        public double GetPerimeter()
        {
            return (height + length);
        }

        public string GetShapeName()
        {
            return "Rectangle";
        }
    }
}