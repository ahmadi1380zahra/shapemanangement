using ShapesManangement.Models.Rectangles.Exceptions;
using ShapesManangement.Models.Squares.Exceptions;


namespace ShapesManangement.Models.Rectangles
{
    public class Rectangles:Shapes
    {
        public Rectangles(double length, double width)
        {
            if (length == width)
            {
                throw new LengthAndWidthCantBeTheSameItsSquareScaleException();
            }
            if (length <= 0)
            {
                throw new LengthShouldBeMoreThanZeroException();
            }
            if (width <= 0)
            {
                throw new WidthShouldBeMoreThanZeroException();
            }
            Length = length;
            Width = width;
        }
        public double Length { get; set; }
        public double Width { get; set; }
        public override double AreaCalculator()
        {
            return Length * Width;
        }

        public override double PerimeterCalculator()
        {
            return 2 * (Length + Width);
        }
    }
}
