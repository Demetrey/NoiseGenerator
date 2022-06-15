using System;
using System.Collections.Generic;
using System.Drawing;

namespace FinalNoise
{
    /// <summary>
    /// Обработка ихображения
    /// </summary>
    class ImageProcessor
    {
        Random random = new Random();

        public delegate void PBValueHandler(int value);
        // Обновление текущего значения прогреса обработки изображения
        public event PBValueHandler PBValNotify;
        // Обновление максимального значения количества пикселей
        public event PBValueHandler PBMaxNotify;
        // Общий прогресс обработки
        public event PBValueHandler PBAllNotify;

        /// <summary>
        /// Наложение эффекта шума на изображение
        /// </summary>
        /// <param name="s_bitmap">Изображение</param>
        /// <param name="renderparam">Параметры обработки</param>
        /// <param name="alg">Алгоритм генерации шума</param>
        /// <param name="persents">Процент задействованных пикелей</param>
        /// <param name="hmimg">Количество изображений</param>
        /// <param name="isBlack">Добавление черного (импульсный шум)</param>
        /// <param name="isWhite">Добавление белого (импульсный шум)</param>
        /// <returns>
        /// Список обработанных изображений 
        /// Изображение с индексом 0 является исходным
        /// </returns>
        public List<Bitmap> Render(Bitmap s_bitmap,
                            float renderparam = 50,
                            int alg = 0,
                            int persents = 0,
                            int hmimg = 100,
                            bool isBlack = false,
                            bool isWhite = false)
        {
            Bitmap bitmap = new Bitmap(s_bitmap);
            List<Bitmap> pictures = new List<Bitmap>(101);
            // Добавляем картинку без шума в список картинок
            pictures.Add(bitmap);
            var pixels = GetPixels(bitmap);
            var pixelsinstep = (bitmap.Width * bitmap.Height) / 100;
            if (hmimg == 1)
                pixelsinstep *= persents;
            var currentpixels = new List<Pixel>(pixels.Count - pixelsinstep);
            float p = 2;
            bool black = false;

            if (isBlack)
            {
                p = 3;
                black = false;
            }
            if (isWhite)
            {
                p = 2;
                black = true;
            }

            for (int i = 0; i < hmimg; i++)
            {
                // Обновление макимального значения
                PBMaxNotify?.Invoke(pixelsinstep);
                // Сбро прогресса
                PBValNotify?.Invoke(0);

                for (int j = 0; j < pixelsinstep; j++)
                {
                    PBValNotify?.Invoke(j + 1);
                    var index = random.Next(pixels.Count);

                    // Выбор алгоритма обработки
                    switch (alg)
                    {
                    case 0:
                        {
                            currentpixels.Add(WhiteNoiseGaus.Effect(pixels[index], 
                                              renderparam));
                            break;
                        }
                    case 1:
                        {
                            currentpixels.Add(WhiteNoise.Effect(pixels[index], 
                                              renderparam));
                            break;
                        }
                    case 2:
                        {
                            currentpixels.Add(AdditiveNoise.Effect(pixels[index], 
                                              renderparam));
                            break;
                        }
                    case 3:
                        {
                            currentpixels.Add(ImpulseNoise.Effect(pixels[index], 
                                              p, black));
                            break;
                        }
                    case 4:
                        {
                            currentpixels.Add(DigitalNoise.Effect(pixels[index], 
                                              renderparam));
                            break;
                        }
                    default:
                        {
                            break;
                        }
                    }
                    pixels.RemoveAt(index);
                }

                var currentbitmap = new Bitmap(bitmap);

                foreach (var pixel in currentpixels)
                {
                    currentbitmap.SetPixel(pixel.Point.X, 
                                           pixel.Point.Y, 
                                           pixel.Color);
                }

                pictures.Add(currentbitmap);
                PBAllNotify?.Invoke(i);
            }
            PBAllNotify?.Invoke(100);
            pixels.Clear();
            currentpixels.Clear();
            return pictures;
        }

        /// <summary>
        /// Полуение списка пикселей из исходного изображения
        /// </summary>
        /// <param name="bitmap">Исходное изображение</param>
        /// <returns>Спиок пикселей изображения</returns>
        private List<Pixel> GetPixels(Bitmap bitmap)
        {
            var pixels = new List<Pixel>(bitmap.Height * bitmap.Width);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    pixels.Add(new Pixel()
                    {
                        Color = bitmap.GetPixel(x, y),
                        Point = new Point { X = x, Y = y }
                    });
                }
            }
            return pixels;
        }
    }
}
