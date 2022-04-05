using System;
using SquareShape.Infrastructure;

namespace SquareShape
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Первая сторона
        /// </summary>
        private int _a;

        /// <summary>
        /// Вторая сторона
        /// </summary>
        private int _b;

        /// <summary>
        /// Третья сторона
        /// </summary>
        private int _c;

        /// <summary>
        /// Конструктор класса - треугольник
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        public Triangle(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double Square()
        {
            if (_a == _b || _b == _c || _c == _a)
                throw new Exception("Это прямоугольный треугольник.");

            var halfPerimeter = (_a + _b + _c) / 2.0;

            return Math.Sqrt(
                halfPerimeter 
                * (halfPerimeter - _a) 
                * (halfPerimeter - _b) 
                * (halfPerimeter - _c));
        }
    }
}
