using ShapesManangement.Models.Circles.Exceptions;


namespace ShapesManangement.Models.Circles
{
    public class Circles:Shapes
    {
        public Circles(double radius)
        {
            if (radius <= 0)
            {
                throw new RadiusShouldBeMoreThanZeroException();
            }
            Radius = radius;
        }
        public double Radius { get; set; }

        public override double AreaCalculator()
        {
            return Math.Round(3.14 * Radius * Radius, 2);
        }

        public override double PerimeterCalculator()
        {
            return Math.Round(3.14 * Radius * 2, 2);
        }
    }
}
