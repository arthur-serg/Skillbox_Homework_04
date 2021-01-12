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

            /*
            Random rnd = new Random();

            int n; //rows number of 1st matrix
            int m; //columns number of 1st matrix

            int k; //rows number of 2nd matrix (for matrix multiplication)
            int l; //columns number of 2nd matrix (for matrix multiplication)

          


            
            #region Умножение матрицы на число.



            double alpha; //multiplier

            Console.WriteLine("Muplitplying matrix by a number;");

            Console.WriteLine("Enter number of rows \'n\' (non negative): ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n <= 0)
            {
                Console.WriteLine("Incorrect \'n\'. Try again.");
                n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter number of columns \'m\' (non negative): ");
            m = Convert.ToInt32(Console.ReadLine());

            while (m <= 0)
            {
                Console.WriteLine("Incorrect \'n\'. Try again.");
                n = Convert.ToInt32(Console.ReadLine());
            }

            double[,] matrix = new double[n, m];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(-10, 11);
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();

            Console.WriteLine("Enter \'alpha\' - multiplier: ");

            alpha = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{alpha} * matrix is:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = alpha * matrix[i, j];
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();

            #endregion

            #region Сложение (вычитание) матриц

            Console.WriteLine("Matrix addition (substraction): ");
            Console.WriteLine("Number of rows and columns of 1st matrix must be the same as 2nd matrix");

            Console.WriteLine("Enter number of rows:");
            n = Convert.ToInt32(Console.ReadLine());

            while (n <= 0)
            {
                Console.WriteLine("Incorrect \'n\'. Try again.");
                n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter number of columns:");
            m = Convert.ToInt32(Console.ReadLine());

            while (m <= 0)
            {
                Console.WriteLine("Incorrect \'m\'. Try again.");
                n = Convert.ToInt32(Console.ReadLine());
            }

            int[,] A = new int[n, m];
            int[,] B = new int[n, m];
            int[,] C = new int[n, m];

            Console.WriteLine("Matrix A: ");

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rnd.Next(-10, 11);
                    Console.Write($"{A[i, j],3} ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Matrix B:");

            for(int i = 0; i < A.GetLength(0); i++)
            {
                for(int j = 0; j < A.GetLength(1); j++)
                {
                    B[i, j] = rnd.Next(-10, 11);
                    Console.Write($"{B[i, j],3} ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Matrix C = A + B:");

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write($"{C[i, j],3} ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Matrix C = A - B:");

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                    Console.Write($"{C[i, j],3} ");
                }
                Console.WriteLine("");
            }


            #endregion



            #region Умножение двух матриц.



            Console.WriteLine("Matrix multiplication.");


            Console.WriteLine("Enter number of rows in 1st matrix:");
            n = Convert.ToInt32(Console.ReadLine());

            while (n <= 0)
            {
                Console.WriteLine("Incorrect \'n\'. Try again.");
                n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter number of columns in 1st matrix:");
            m = Convert.ToInt32(Console.ReadLine());

            while (m <= 0)
            {
                Console.WriteLine("Incorrect \'m\'. Try again.");
                n = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Enter number of rows in 2nd matrix:");
            k = Convert.ToInt32(Console.ReadLine());

            while (k != m)
            {
                while (k <= 0)
                {
                    Console.WriteLine("Incorrect \'k\'. Try again.");
                    k = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Number of rows in 2nd matrix must be the same as number of columns in 1st matrix.");
                Console.WriteLine("Incorrect input. Try again!");
                Console.WriteLine("Enter number of rows in 2nd matrix:");
                k = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter number of columns in 2nd matrix:");
            l = Convert.ToInt32(Console.ReadLine());

            while (l <= 0)
            {
                Console.WriteLine("Incorrect \'l\'. Try again.");
                l = Convert.ToInt32(Console.ReadLine());
            }


            int[,] matrixA = new int[n, m];
            int[,] matrixB = new int[k, l];
            int[,] matrixC = new int[n, l];

            Console.WriteLine("Matrix A: ");

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixA[i, j] = rnd.Next(-10, 11);
                    Console.Write($"{matrixA[i, j],3} ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Matrix B: ");
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixB[i, j] = rnd.Next(-10, 11);
                    Console.Write($"{matrixB[i, j],3} ");
                }
                Console.WriteLine("");
            }

            //multiplication A*B.

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int s = 0; s < matrixB.GetLength(0); s++)
                    {
                        matrixC[i, j] = matrixC[i, j] + matrixA[i,s] * matrixB[s,j];
                    }
                }
            }

            Console.WriteLine("Matrix C: ");
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    Console.Write($"{matrixC[i, j],5} ");
                }
                Console.WriteLine("");
            }




            Console.ReadKey();

            #endregion

    */
            #endregion

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
