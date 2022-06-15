using System;   

namespace FinalNoise
{
    /// <summary>
    /// Генерация равномерного белого шума
    /// </summary>
    static class WhiteNoise
    {
        /// <summary>
        /// Изменение пикселя
        /// </summary>
        /// <param name="pixel"></param>
        /// <param name="renderParam"></param>
        /// <returns></returns>
        static public Pixel Effect(Pixel pixel, float renderParam = 50)
        {
            Random rnd = new Random();
            // равномерное распределение от a до b
            // метод инверсии
            // a = -renderparam; b = renderparam
            // a + BasicRandGenerator() * (b - a) / RAND_MAX;
            double coef = (renderParam - (-renderParam)) / 255;  // (b - a) / RAND_MAX
            double noise = (-renderParam) + rnd.Next(255) * coef;  // равномерное распределение
            pixel.SetColor(pixel.Color.R + noise, pixel.Color.G + noise, pixel.Color.B + noise);
            return pixel;
        }
    }
}
