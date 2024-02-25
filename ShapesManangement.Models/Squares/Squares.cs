using ShapesManangement.Models.Squares.Exceptions;

namespace ShapesManangement.Models.Squares
{
    public class Squares:Shapes
    {

        public Squares(double length)
        {
            if (length <= 0)
            {
                throw new LengthShouldBeMoreThanZeroException();
            }
            Length = length;
        }
        public double Length { get; set; }
        public override double AreaCalculator()
        {
            return Length * Length;
        }

        public override  double PerimeterCalculator()
        {
            return Length * 4;
        }

    }
}