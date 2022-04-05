using SquareShape.Infrastructure;
using System;

namespace SquareShape
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус
        /// </summary>
        private int _r;
        
        /// <summary>
        /// Конструктор класса - круг
        /// </summary>
        /// <param name="r">Радиус</param>
        public Circle(int r)
        {
            _r = r;
        }

        public double Square()
        {
            return Math.PI * Math.Pow(_r, 2);
        }
    }
}
