using FluentAssertions;
using ShapesManangement.Models.Squares.Exceptions;
using ShapesManangement.Models.Squares;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesManangement.Models.Rectangles;
using ShapesManangement.Models.Rectangles.Exceptions;

namespace ShapesManangement.Unit.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void AreaCalculator_calculate_area_of_rectangle_given_two_parameter_properly()
        {
            var length = 5;
            var width = 3;
            var expected = 15;
            var rectangle = new Rectangles(length, width);

            var actual = rectangle.AreaCalculator();

            actual.Should().Be(expected);
        }
        [Fact]
        public void PerimeterCalculator_calculate_area_of_rectangle_given_two_parameter_properly()
        {
            var length = 5;
            var width = 3;
            var expected = 16;
            var rectangle = new Rectangles(length, width);

            var actual = rectangle.PerimeterCalculator();

            actual.Should().Be(expected); 
        }
        [Fact]
        public void
            Rectangles_throws_LengthAndWidthCantBeTheSameItsSquareScaleException_when_two_parameter_are_the_same()
        {
            var length = 3;
            var width = 3;

            var actual =()=> new Rectangles(length, width);

            actual.Should().ThrowExactly<LengthAndWidthCantBeTheSameItsSquareScaleException>();
        }
        [Fact]
        public void Rectangles_throws_LengthShouldBeMoreThanZeroException_when_length_is_less_than_zero()
        {
            var length = -10;
            var width = 3;

            var actual = () => new Rectangles(length,width);

            actual.Should().ThrowExactly<LengthShouldBeMoreThanZeroException>();
        }
        [Fact]
        public void Rectangles_throws_widthShouldBeMoreThanZeroException_when_width_is_less_than_zero()
        {
            var length = 10;
            var width = -3;

            var actual = () => new Rectangles(length, width);

            actual.Should().ThrowExactly<WidthShouldBeMoreThanZeroException>();
        }
    }
}
