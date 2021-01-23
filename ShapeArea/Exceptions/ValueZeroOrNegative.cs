using System;

namespace ShapeArea.Exceptions {
    public class ValueZeroOrNegative : Exception {
        public ValueZeroOrNegative() { }

        public ValueZeroOrNegative(string message) : base(message) { }

        public ValueZeroOrNegative(string message, Exception inner) : base(message, inner) { }
    }
}
