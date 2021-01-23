using System;
using ShapeArea;
using ShapeArea.Exceptions;
using Xunit;

namespace ShapeArea.Tests {
    public class TriangleTest {
       [Theory]
       [MemberData(nameof(TriangleTestArguments.ZeroOrNegativeValue), MemberType = typeof(TriangleTestArguments))]

        public void CalculateArea_NegativeOrZeroParams_Throws(double side_1, double side_2, double side_3) {
            Assert.Throws<ValueZeroOrNegative>(() => new Triangle(side_1, side_2, side_3));
        }

        [Theory]
        [MemberData(nameof(TriangleTestArguments.TriangleNotExist), MemberType = typeof(TriangleTestArguments))]

        public void CalculateArea_SidesForNoExistsTriangle_Throws(double side_1, double side_2, double side_3) {
            Assert.Throws<TriangleNotExist>(() => new Triangle(side_1, side_2, side_3));
        }

        [Theory]
        [MemberData(nameof(TriangleTestArguments.TriangleIsRight), MemberType = typeof(TriangleTestArguments))]

        public void TriangleIsRight_ForRightTriangle_True(double side_1, double side_2, double side_3) {
            Triangle triangle = new Triangle(side_1, side_2, side_3);
            var actual = triangle.TriangleIsRight();
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(TriangleTestArguments.TriangleIsNotRight), MemberType = typeof(TriangleTestArguments))]

        public void TriangleIsRight_ForNotRightTriangle_False(double side_1, double side_2, double side_3) {
            Triangle triangle = new Triangle(side_1, side_2, side_3);
            var actual = triangle.TriangleIsRight();
            Assert.False(actual);
        }
    }
}
