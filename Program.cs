using System;

namespace TaskJunior4
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesInTheAlbum = 52, groupOfImages = 3, displayingImagesInARow;
            float outputOfTheRemainingImages;

            displayingImagesInARow = picturesInTheAlbum / groupOfImages;

            outputOfTheRemainingImages = picturesInTheAlbum % groupOfImages;

            Console.WriteLine($"Задача:\n\nВывод кол-ва картинок 3 в ряд:\n\n- полностью заполненых\n- остаток картинок\n\nДано:\n\n52 картинки\n\nРешение:\n");
            Console.WriteLine($"- кол-во заполненых картинок 3 в ряд: {displayingImagesInARow}");
            Console.WriteLine($"- остаток картинок: {outputOfTheRemainingImages}");
        }
    }
}
