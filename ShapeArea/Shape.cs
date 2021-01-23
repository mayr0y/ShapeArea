using System;
using ShapeArea.Exceptions;

namespace ShapeArea {
    public abstract class Shape {
        internal abstract double CalculateArea();

        protected double CheckForZeroValue(double value) {
            if (value <= 0)
                throw new ValueZeroOrNegative();
            return value;
        }
    }
}