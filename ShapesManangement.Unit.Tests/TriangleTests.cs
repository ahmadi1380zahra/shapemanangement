using FluentAssertions;
using ShapesManangement.Models.Squares.Exceptions;
using ShapesManangement.Models.Squares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesManangement.Models.Triangles.Exceptions;
using ShapesManangement.Models.Triangles;

namespace ShapesManangement.Unit.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void AreaCalculator_calculate_area_of_triangle_given_two_parameter_properly()
        {
            var baseLength = 3;
            var height = 4;
            var expected = 6;
            var triangle = new Triangle(baseLength, height);

            var actual = triangle.AreaCalculator();

            actual.Should().Be(expected);
        }
        [Fact]
        public void PerimeterCalculator_calculate_area_of_triangle_given_two_parameter_properly()
        {
            var baseLength = 3;
            var sideLength1 = 5;
            var sideLength2 = 2;
            var expected = 10;
            var triangle = new Triangle(baseLength, sideLength1, sideLength2);

            var actual = triangle.PerimeterCalculator();

            actual.Should().Be(expected);
        }


        [Fact]
        public void Triangle_throws_HeightCouldNotBeLessThanZeroException_when_height_is_less_than_zero()
        {
            var baseLength = 10;
            var height = -4;

            var actual = () => new Triangle(baseLength, height);

            actual.Should().ThrowExactly<HeightCouldNotBeLessThanZeroException>();
        }
        [Fact]
        public void Triangle_throws_BaseLengthCouldNotBeLessThanZeroException_when_Baselength_is_less_than_zero()
        {
            var baseLength = -10;
            var height = 4;

            var actual = () => new Triangle(baseLength, height);

            actual.Should().ThrowExactly<BaseLengthCouldNotBeLessThanZeroException>();
        }
        //q
        //[Fact]
        //public void Triangle_throws_BaseLengthCouldNotBeLessThanZeroException_when_Baselength_is_less_than_zero()
        //{
        //    var baseLength = -10;
        //    var sideLength1 = 5;
        //    var sideLength2 = 2;
        //    var triangle = new Triangle();

        //    var actual = () => triangle.PerimeterCalculator(baseLength, sideLength1, sideLength2);

        //    actual.Should().ThrowExactly<BaseLengthCouldNotBeLessThanZeroException>();
        //}
        [Fact]
        public void Triangle_throws_sideLength1CouldNotBeLessThanZeroException_when_sideLength1_is_less_than_zero()
        {
            var baseLength = 3;
            var sideLength1 = -5;
            var sideLength2 = 2;

            var actual = () => new Triangle(baseLength, sideLength1, sideLength2);

            actual.Should().ThrowExactly<sideLength1CouldNotBeLessThanZeroException>();
        }
        [Fact]
        public void Triangle_throws_sideLength2CouldNotBeLessThanZeroException_when_sideLength2_is_less_than_zero()
        {
            var baseLength = 3;
            var sideLength1 = 5;
            var sideLength2 = -2;

            var actual = () => new Triangle(baseLength, sideLength1, sideLength2);

            actual.Should().ThrowExactly<sideLength2CouldNotBeLessThanZeroException>();
        }

    }
}
