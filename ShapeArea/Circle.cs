using System;

namespace ShapeArea {
    public class Circle : Shape {
        private readonly double radius;

        public Circle(double _radius) {
            radius = CheckForZeroValue(_radius);
        }

        internal override double CalculateArea() {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
