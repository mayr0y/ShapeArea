using System;
using ShapeArea.Exceptions;

namespace ShapeArea {
    public class Triangle : Shape {
        private readonly double side_1;
        private readonly double side_2;
        private readonly double side_3;

        public Triangle(double _side_1, double _side_2, double _side_3) {
            side_1 = CheckForZeroValue(_side_1);
            side_2 = CheckForZeroValue(_side_2);
            side_3 = CheckForZeroValue(_side_3);

            TriangleExist();
        }

        protected void TriangleExist() {
            if (side_1 > side_2 + side_3)
                throw new TriangleNotExist();
            if (side_2 > side_1 + side_3)
                throw new TriangleNotExist();
            if (side_3 > side_1 + side_2)
                throw new TriangleNotExist();
        }

        public bool TriangleIsRight() {
            if (side_1 > side_2 && side_1 > side_3)
                return TeoremaPythagoras(side_2, side_3, side_1);
            if (side_2 > side_1 && side_2 > side_3)
                return TeoremaPythagoras(side_1, side_3, side_2);
            if (side_3 > side_1 && side_3 > side_2)
                return TeoremaPythagoras(side_1, side_2, side_3);
            return false;
        }

        private bool TeoremaPythagoras(double leg_1, double leg_2, double hypotenuse) {
            var squareHypotenuse = Math.Pow(hypotenuse, 2);
            var squareSumLeg = Math.Pow(leg_1, 2) + Math.Pow(leg_2, 2);

            return squareHypotenuse.Equals(squareSumLeg);
        }

        internal override double CalculateArea() {
            var halfPerimeter = (side_1 + side_2 + side_3) / 2;
            var area = Math.Sqrt(halfPerimeter * (halfPerimeter - side_1) *
                (halfPerimeter - side_2) * (halfPerimeter - side_3));
            return area;
        }
    }
}
