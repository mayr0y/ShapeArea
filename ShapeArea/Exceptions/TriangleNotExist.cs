using System;

namespace ShapeArea.Exceptions {
    public class TriangleNotExist : Exception {
        public TriangleNotExist() { }

        public TriangleNotExist(string message) : base(message) { }

        public TriangleNotExist(string message, Exception inner) : base(message, inner) { }
    }
}
