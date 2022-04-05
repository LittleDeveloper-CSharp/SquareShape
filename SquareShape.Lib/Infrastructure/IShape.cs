namespace SquareShape.Infrastructure
{
    /// <summary>
    /// Интерфейс фигуры
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Вычисляет площадь фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        double Square();
    }
}
