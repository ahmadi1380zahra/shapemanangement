using ShapesManangement.Models.Triangles.Exceptions;

namespace ShapesManangement.Models.Triangles
{
    public class Triangle : Shapes
    {
        public Triangle(double baseLength, double height)
        {
            if (baseLength <= 0)
            {
                throw new BaseLengthCouldNotBeLessThanZeroException();
            }
            if (height <= 0)
            {
                throw new HeightCouldNotBeLessThanZeroException();
            }
            Height = height;
            BaseLength = baseLength;
        }
        public Triangle(double baseLength, double sideLength1, double sideLength2)
        {
            if (baseLength <= 0)
            {
                throw new BaseLengthCouldNotBeLessThanZeroException();
            }
            if (sideLength1 <= 0)
            {
                throw new sideLength1CouldNotBeLessThanZeroException();
            }
            if (sideLength2 <= 0)
            {
                throw new sideLength2CouldNotBeLessThanZeroException();
            }
            BaseLength = baseLength;
            SideLength1=sideLength1;
            SideLength2=sideLength2;
        }

        public double BaseLength { get; set; }
        public double SideLength1 { get; set; }
        public double SideLength2 { get; set; }
        public double Height { get; set; }

        public override  double AreaCalculator()
        {
       
            return 0.5 * BaseLength * Height;
        }

     

        public override double PerimeterCalculator()
        {
       
            return BaseLength + SideLength1 + SideLength2;
        }

      
    }
}
