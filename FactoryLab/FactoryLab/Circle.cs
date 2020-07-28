namespace FactoryLab
{
    internal class Circle : IShape
    {
        private double radius = 1;

        public Circle()
        {
            this.radius = 1;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle (double[] specifications)
        {
            this.radius = specifications[0];
        }

        public double GetArea()
        {
            return radius*radius*3.14;
        }

        public double GetPerimeter()
        {
            return 2*radius*3.14;
        }

        public string GetShapeName()
        {
            return "Circle";
        }
    }
}