using FluentAssertions;
using ShapesManangement.Models.Squares.Exceptions;
using ShapesManangement.Models.Squares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesManangement.Models.Circles.Exceptions;
using ShapesManangement.Models.Circles;

namespace ShapesManangement.Unit.Tests
{
    public class CircleTests
    {
        [Fact]
        public void AreaCalculator_calculates_area_of_circle_given_one_parameter_properly()
        {
            var radius = 3;
            var excpected = 28.26;
            var circle = new Circles(radius);

            var actual = circle.AreaCalculator();

            actual.Should().Be(excpected);
        }
        [Fact]
        public void PerimeterCalculator_calculates_area_of_circle_given_one_parameter_properly()
        {
            var radius = 3;
            var excpected = 18.84;
            var circle = new Circles(radius);

            var actual = circle.PerimeterCalculator();

            actual.Should().Be(excpected);
        }
        [Fact]
        public void Circles_throws_RadiusShouldBeMoreThanZeroException_when_radius_is_less_than_zero()
        {
            var radius = -9;

            var actual = () => new Circles(radius);

            actual.Should().ThrowExactly<RadiusShouldBeMoreThanZeroException>();
        }
    }
}
