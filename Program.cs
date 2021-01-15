using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            int[,] array = new int[12, 4];

            string[] header =
                {
                "Месяц",
                "Доход, тыс. руб.",
                "Расход, тыс. руб.",
                "Прибыль, тыс. руб."
            };



            //хотел для удобства сделать вывод с выравниванием по максимальной длине заголовка. не вышло.
            int[] headerLengths = new int[header.Length];

            for (int i = 0; i < header.Length; i++)
            {
                //  Console.WriteLine($"{header[i].ToString().Length}");
                headerLengths[i] = header[i].ToString().Length;
            }
            int maxHeaderLength = Convert.ToInt32(headerLengths.Max());


            Console.WriteLine($"{header[0],18} {header[1],18} {header[2],18} {header[3],18}");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 10) * 1000;
                    array[i, 0] = i + 1;
                    array[i, array.GetLength(1) - 1] = array[i, array.GetLength(1) - 3] - array[i, array.GetLength(1) - 2];
                    Console.Write($"{array[i, j],18} ");
                }
                Console.WriteLine();
            }

            Console.Write("Месяцы с положительной прибылью: ");
            int counter = 0; //счётчик месяцев  положит. прибылью
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, array.GetLength(1) - 1] > 0)
                {
                    Console.Write(i + 1 + " ");
                    counter++;
                }
            }

            Console.WriteLine($"\nВсего месяцев с положительной прибылью:  {counter}.");



            Console.Write("Месяцы с отрицательной прибылью: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, array.GetLength(1) - 1] < 0)
                {
                    Console.Write(i + 1 + " ");
                }
            }
            Console.WriteLine();


            int[] income = new int[array.GetLength(0)]; //Прибыль

            for (int i = 0; i < income.Length; i++)
            {
                income[i] = array[i, 3];
            }


            int[] sorted = new int[array.GetLength(0)];
            int[] indices = new int[income.Length];
            bool isExist = false;

            Array.Copy(income, sorted, income.Length);
            Array.Sort(sorted);

            Console.WriteLine($"   i\t income     sorted");

            int minElemCount = 4;
            int uniqueIndex = 0;

            indices[0] = Array.IndexOf(income, sorted[0]) + 1;

            Console.WriteLine($"{0 + 1,4} {income[0],10} {sorted[0],10} {indices[0],10}");

            for (int i = 1; i < sorted.Length; i++)
            {
                if (uniqueIndex <= minElemCount)
                {
                    if (sorted[i - 1] != sorted[i])
                    {
                        indices[i] = Array.IndexOf(income, sorted[i]) + 1;
                        uniqueIndex++;
                    }

                    else
                    {
                        indices[i] = Array.IndexOf(income, sorted[i], indices[i - 1]) + 1;
                    }
                }
                Console.WriteLine($"{i + 1,4} {income[i],10} {sorted[i],10} {indices[i],10}");
            }
            Console.WriteLine($"{minElemCount} Месяца с худшей прибылью: ");
            for (int i = 0; i < minElemCount; i++)
            {
                Console.Write($"{indices[i]} ");
            }
            Console.ReadKey();
        }
    }
}
