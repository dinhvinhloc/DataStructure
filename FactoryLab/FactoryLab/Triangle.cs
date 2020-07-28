namespace FactoryLab
{
    internal class Triangle : IShape
    {
        private double height = 1;
        private double length = 1;

        public Triangle()
        {
        }

        public Triangle(double specifications)
        {
            this.length = specifications;
        }

        public Triangle(double [] specifications)
        {
            this.height = specifications[0];
            this.length = specifications[1];
        }


        public double GetArea()
        {
            return height*length/2;
        }

        public double GetPerimeter()
        {
            return (height+length)/2;
        }

        public string GetShapeName()
        {
            return "Triangle";
        }
    }
}