using Frequency_Var_2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Frequency_Var_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazine magazine = new Magazine();

            Console.WriteLine(magazine.ToShortString());

            Console.WriteLine(magazine[FrequencyEnum.Monthly]);
            Console.WriteLine(magazine[FrequencyEnum.Weekly]);
            Console.WriteLine(magazine[FrequencyEnum.Yearly]);

            magazine.name = "Vogue";
            magazine.frequency = FrequencyEnum.Monthly;
            magazine.circulation = 3;
            magazine.releaseDate = new DateTime(2021, 1, 31);
            magazine.articles = new List<Article>() { new Article(new Person("Maryna", "Gulpak", new DateTime(2000, 4, 24)), "Fashion", 9.8), new Article(new Person("Yuri", "Kuz", new DateTime(1999, 7, 14)), "Models", 7.4) };

            Console.WriteLine($"\nMAGAZINE:\n\t{magazine.name}\n\t{magazine.frequency.ToString()}\n\t" +
                $"{magazine.circulation.ToString()}" +
                $"\n\t{magazine.releaseDate.ToString()}\n");

            foreach (var element in magazine.articles)
            {
                Console.WriteLine(element.ToString());
            }

            Console.WriteLine($"Average rating: {magazine.AverageRating}");
            magazine.AddArticles(new Article(new Person("Ihor", "Shapovalov", new DateTime(1971, 11, 29)), "Style", 7.9));
            Console.WriteLine(magazine.ToString());
            Console.WriteLine($"Average rating: {magazine.AverageRating}");

            int nRows, nColumns;
            string strAmount;
            char separator;

            Console.WriteLine("Please, choose the separator:  ,  /  .  \n");
            separator = Console.ReadKey().KeyChar;
            Console.WriteLine("\nAnd input amount of  rows and  amount of columns with chosen separator\n");
            strAmount = Console.ReadLine();

            var rowsAndColumnsAmount = strAmount.Split(separator);
            nRows = Convert.ToInt32(rowsAndColumnsAmount.GetValue(0));
            nColumns = Convert.ToInt32(rowsAndColumnsAmount.GetValue(1));

            Article[] articlesOneDimensionalArray = new Article[nRows * nColumns];
            Article[,] articlesTwoDimensionalArray = new Article[nRows, nColumns];
            Article[][] articlesSteppedArray = new Article[nRows][];

            for (int i = 0; i < nRows * nColumns; i++)
            {
                articlesOneDimensionalArray[i] = new Article();
            }

            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nColumns; j++)
                {
                    articlesTwoDimensionalArray[i, j] = new Article();
                }
            }

            for (int i = 0; i < nRows; i++)
            {
                articlesSteppedArray[i] = new Article[4];
            }
                for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nColumns; j++)
                {
                    articlesSteppedArray[i][j] = new Article();
                }
            }


            Stopwatch sw = new Stopwatch();
            sw.Start();
            long start1, result1, start2, result2, start3, result3;
            start1 = sw.ElapsedTicks;

            double startTimeOneDimensionalArray = Environment.TickCount;

            for (int i = 0; i < nRows * nColumns; i++)
            {
                articlesOneDimensionalArray[i].Name = "Mykola";
            }
            result1 = sw.ElapsedTicks - start1;
            sw.Stop();
            double endTimeOneDimensionalArray = Environment.TickCount;

            sw.Start();
            start2 = sw.ElapsedTicks;
            double startTimeTwoDimensionalArray = Environment.TickCount;
            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nColumns; j++)
                {
                    articlesTwoDimensionalArray[i, j].Name = "Mykola";
                }
            }
            double endTimeTwoDimensionalArray = Environment.TickCount;
            result2 = sw.ElapsedTicks - start2;

            sw.Start();
            start3 = sw.ElapsedTicks;
            double startTimeSteppedArray = Environment.TickCount;
            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nColumns; j++)
                {
                    articlesSteppedArray[i][j].Name = "Mykola";
                }
            }
            double endTimeSteppedArray = Environment.TickCount;
            result3 = sw.ElapsedTicks - start2;

            /*int resultTimeOneDimensionalArray = endTimeOneDimensionalArray - startTimeOneDimensionalArray;
            int resultTimeTwoDimensionalArray = endTimeTwoDimensionalArray - startTimeTwoDimensionalArray;
            int resultTimeSteppedArray = endTimeSteppedArray - startTimeSteppedArray;*/

            Console.WriteLine($"Rows: {nRows}\nColumns: {nColumns}\n\nOneDimensionalArrayTime: {result1} ms\n" +
                $"TwoDimensionalArrayTime: {result2} ms\nSteppedArrayTime: {result3} ms");

        }
    }
}
