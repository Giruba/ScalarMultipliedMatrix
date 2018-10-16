using System;

namespace MatrixScalarMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix Scalar Multiplication!");
            Console.WriteLine("------------------------------");
            try
            {
                int input = 1;
                do
                {
                    Console.WriteLine("Enter the number of rows");
                    int rows = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the number of columns");
                    int cols = int.Parse(Console.ReadLine());
                    int[,] matrix = new int[rows, cols];
                    Console.WriteLine("Enter the contents of the matrix");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            matrix[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                    Console.WriteLine("Enter the scalar for multiplication");
                    int scalar = int.Parse(Console.ReadLine());
                    MatrixManipulator matrixManipulator = new MatrixManipulator(matrix);
                    Console.WriteLine("Original Matrix-----------------------");
                    matrixManipulator.PrintMatrix();
                    Console.WriteLine();
                    Console.WriteLine("Scalar Multiplied Matrix-----------------------");
                    matrixManipulator.PrintScalarMultipliedMatrix(scalar);
                    Console.WriteLine();


                    Console.WriteLine("Enter 1 to continue and 0 to stop");
                    input = int.Parse(Console.ReadLine());
                } while (input == 1);
            }
            catch (Exception exception) {
                Console.WriteLine("The thrown exception is"+exception.Message);
            }

            Console.ReadLine();
        }
    }
}
