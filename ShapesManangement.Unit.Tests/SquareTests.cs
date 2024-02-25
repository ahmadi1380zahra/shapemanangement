using FluentAssertions;
using ShapesManangement.Models.Squares;
using ShapesManangement.Models.Squares.Exceptions;

namespace ShapesManangement.Unit.Tests
{
    public class SquareTests
    {
        [Fact]
        public void AreaCalculator_calculate_area_of_square_given_one_parameter_properly()
        {
            var length = 6;
            var expected = 36;
            var square = new Squares(length);

            var actual = square.AreaCalculator(); 

            actual.Should().Be(expected);
        }
        [Fact]
        public void PerimeterCalculator_calculate_area_of_square_given_one_parameter_properly()
        {
            var length = 6;
            var expected = 24;
            var square = new Squares(length);

            var actual = square.PerimeterCalculator();

            actual.Should().Be(expected);
        }
        [Fact]
        public void Squares_throws_LengthShouldBeMoreThanZeroException_when_length_is_less_than_zero()
        {
            var length =-10;

            var actual = () => new Squares(length);

            actual.Should().ThrowExactly<LengthShouldBeMoreThanZeroException>();
        }
    }
}