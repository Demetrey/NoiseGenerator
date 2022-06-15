using System;

namespace FinalNoise
{
    /// <summary>
    /// Генерация аддитивного шума
    /// </summary>
    static class AdditiveNoise
    {
        /// <summary>
        /// Изменение пикселя
        /// </summary>
        /// <param name="pixel">Целевой пиксель</param>
        /// <param name="renderParam">Параметр генерации шума (диапазон)</param>
        /// <returns>Измененный пиксель</returns>
        static public Pixel Effect(Pixel pixel, float renderParam = 50)
        {
            Random rnd = new Random();
            // Установка отрицательного или положительного значения изменения цвета пикселя
            float noise = rnd.Next(1, 100) > 50 ? (-renderParam) : renderParam;
            pixel.SetColor(pixel.Color.R + noise, pixel.Color.G + noise, pixel.Color.B + noise);
            return pixel;
        }
    }
}
