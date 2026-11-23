namespace VariablesAndDatatypes
{
    public class Circle
    {
        // TODO 1: declare a constant named PI, initialised to 3.14.
        public const double PI = 3.14;

        // Stretch: add a method Area that takes one double radius
        // and returns PI * radius * radius.
        public double Area(double radius)
        {
            return PI * radius * radius;
        }

        // Stretch: add a method Perimeter that takes one double radius
        // and returns 2 * PI * radius.
        public double Perimeter(double radius)
        {
            return 2 * PI * radius;
        }
    }
}

