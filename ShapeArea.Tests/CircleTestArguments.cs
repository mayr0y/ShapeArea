using System;
using System.Collections.Generic;

namespace ShapeArea.Tests {
    public class CircleTestArguments {
        public static IEnumerable<object[]> ZeroOrNegativeValue() {
            yield return new object[] {
                -1d,
            };
            yield return new object[] {
                0
            };
        }
    }
}
