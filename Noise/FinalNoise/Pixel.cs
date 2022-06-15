using System.Drawing;

namespace FinalNoise
{
    /// <summary>
    /// Хранение информации о пикселе изображения
    /// </summary>
    class Pixel
    {
        // Координаты
        public Point Point { get; set; }
        // Цвет
        public Color Color { get; set; }

        /// <summary>
        /// Установка цвета пикселя
        /// </summary>
        /// <param name="r">Значение красного канала</param>
        /// <param name="g">Значение зеленого канала</param>
        /// <param name="b">Значение синего канала</param>
        public void SetColor(double r, double g, double b)
        {
            // Проверка на выход за диапазон
            if (r < 0)
                r = 0;
            else if (r > 255)
                r = 255;
            if (g < 0)
                g = 0;
            else if (g > 255)
                g = 255;
            if (b < 0)
                b = 0;
            else if (b > 255)
                b = 255;
            // Установка значения цвета
            Color = Color.FromArgb((int)r, (int)g, (int)b);
        }
    }
}
