using System;
using System.Collections.Generic;

namespace ShapeArea.Tests {
    public class TriangleTestArguments {
        public static IEnumerable<object []> ZeroOrNegativeValue() {
            yield return new object[] {
                -3d,
                4d,
                5d
            };
            yield return new object[] {
                3d,
                -4d,
                5d
            };
            yield return new object[] {
                3d,
                4d,
                -5d
            };
            yield return new object[] {
                3d,
                4d,
                0
            };
        }

        public static IEnumerable<object []> TriangleNotExist() {
            yield return new object[] {
                1d,
                2d,
                5d
            };
        }

        public static IEnumerable<object []> TriangleIsRight() {
            yield return new object[] {
                3d,
                4d,
                5d
            };
        }

        public static IEnumerable<object[]> TriangleIsNotRight() {
            yield return new object[] {
                2d,
                4d,
                5d
            };
        }
    }
}
