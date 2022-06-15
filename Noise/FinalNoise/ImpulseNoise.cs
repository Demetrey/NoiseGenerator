using System;

namespace FinalNoise
{
    /// <summary>
    /// Генерация импульсного шума (соль и перец)
    /// </summary>
    static class ImpulseNoise
    {
        /// <summary>
        /// Изменение целевого пикселя
        /// </summary>
        /// <param name="pixel">Целевой пиксель</param>
        /// <param name="renderParam">Параметр генерации (диапазон)</param>
        /// <param name="view">Покрака в белый</param>
        /// <returns>Измененный пиксель</returns>
        static public Pixel Effect(Pixel pixel, double renderParam, bool view = false)
        {
            Random rnd = new Random();
            float noise = 0;
            double p = renderParam * rnd.NextDouble();
            // выбор действия с пикселем
            if(p > 1 && p < 2)
            {
                // перекрасить в белый
                if (!view)
                    noise = 255;
                pixel.SetColor(noise, noise, noise);
            }
            else if(p > 2)
            {
                // перекрасить в черный (если выбрана опция генерации Соли и Перца)
                pixel.SetColor(noise, noise, noise);
            }

            return pixel;
        }
    }
}
