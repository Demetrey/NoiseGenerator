using System;

namespace FinalNoise
{
    /// <summary>
    /// Алгоритм генерации цифрового шума
    /// </summary>
    static class DigitalNoise
    {
        /// <summary>
        /// Добавление эффекта шума для пикселя
        /// Зашумление выполняется для одного канала (R, G или B) с 
        /// </summary>
        /// <param name="pixel">Целевой пиксель</param>
        /// <param name="renderParam">Параметр шума (диапазон генерации)</param>
        /// <returns>Измененный пиксель</returns>
        static public Pixel Effect(Pixel pixel, double renderParam)
        {
            Random rnd = new Random();
            float noise = rnd.Next(-(int)renderParam, (int)renderParam);
            double p = 4 * rnd.NextDouble();
            // Выбор действия с пикселем
            if (p < 1)
            {
                // Оставить пиксель нетронутым
                return pixel;
            }
            else if (p < 2)
            {
                // Добавить шум в красном канале
                pixel.SetColor(pixel.Color.R + noise, pixel.Color.G, pixel.Color.B);
            }
            else if(p < 3)
            {
                // Добавить шум в зеленом канале
                pixel.SetColor(pixel.Color.R, pixel.Color.G + noise, pixel.Color.B);
            }
            else
            {
                // Добавить шум в синем канале
                pixel.SetColor(pixel.Color.R, pixel.Color.G, pixel.Color.B + noise);
            }

            return pixel;
        }
    }
}
