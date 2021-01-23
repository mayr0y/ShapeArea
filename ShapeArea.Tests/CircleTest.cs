using System;
using ShapeArea;
using ShapeArea.Exceptions;
using Xunit;

namespace ShapeArea.Tests {
    public class CircleTest {
        [Theory]
        [MemberData(nameof(CircleTestArguments.ZeroOrNegativeValue), MemberType = typeof(CircleTestArguments))]

        public void CalculateArea_NegativeOrZeroParams_Throws(double radius) {
            Assert.Throws<ValueZeroOrNegative>(() => new Circle(radius));
        }

        [Fact]
        public void CalculateArea_ValidValue_Correct() {
            const double radius = 3d;
            const double expectedArea = Math.PI * radius * radius;

            Circle circle = new Circle(radius);

            var actualArea = circle.CalculateArea();

            Assert.Equal(expectedArea, actualArea);
        }
    }
}
