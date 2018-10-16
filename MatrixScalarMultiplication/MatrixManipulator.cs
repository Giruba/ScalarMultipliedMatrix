using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixScalarMultiplication
{
    class MatrixManipulator
    {
        int[,] matrix;

        private MatrixManipulator() { }

        public MatrixManipulator(int[,] matrix) {
            this.matrix = matrix;
        }

        public void PrintScalarMultipliedMatrix(int scalar) {

            for (int i = 0; i < this.matrix.GetLength(0); i++) {
                for (int j = 0; j < this.matrix.GetLength(1); j++) {
                    this.matrix[i, j] = scalar * this.matrix[i, j];
                }
            }

            PrintMatrix();
        }

        public void PrintMatrix(){
            for (int i = 0; i < this.matrix.GetLength(0); i++) {
                for (int j = 0; j < this.matrix.GetLength(1); j++) {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
