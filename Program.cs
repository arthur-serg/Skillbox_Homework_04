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
            #region commented

            int n; //number of rows in triangle

            Console.WriteLine("Enter number of rows in triangle (<25):");

           
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Triangle:");
            int[][] arr = new int[n][];

            for (int i=0; i < n; i++)
            {
               
                arr[i] = new int[i + 1];

                arr[i][0] = 1;
                arr[i][i] = 1;

                Console.Write($"{arr[i][0]} ");
                for (int j = 1; j < arr[i].Length-1; j++)
                {
                    arr[1][1] = 1;
                    arr[i][j] = arr[i - 1][j - 1] + arr[i - 1][j];
                    
                    Console.Write($"{arr[i][j],4} ");

                }
                if (i != 0)
                {
                    Console.Write($"{arr[i][i],4} ");
                }
                

                Console.WriteLine();

                

            }

            Console.ReadKey();
            
        }
    }
}
