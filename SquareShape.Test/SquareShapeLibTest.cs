using SquareShape.Infrastructure;
using System;
using Xunit;

namespace SquareShape.Test
{
    public class SquareShapeLibTest
    {
        [Fact]
        public void CircleSquary()
        {
            IShape circle= new Circle(4);

            var square = circle.Square();

            Assert.Equal(50.26548245743669, square);
        }

        [Fact]
        public void RightTriangleException()
        {
            IShape triangle = new Triangle(4, 4, 2);

            Assert.ThrowsAny<Exception>(() => triangle.Square());
        }

        [Fact]
        public void TringleSquare()
        {
            IShape triangle = new Triangle(4, 6, 5);

            var square = triangle.Square();

            Assert.Equal(9.921567416492215, square);
        }
    }
}
