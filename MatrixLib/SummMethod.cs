using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLib
{
    public static class SummMethod
    {
        public static SquareMatrix<T> Add<T>(this SquareMatrix<T> matrix, SquareMatrix<T> addMatrix)
        {            
            return new SquareMatrix<T>(AddLogic(matrix,addMatrix));
        }

        public static SymmetricalMatrix<T> Add<T>(this SymmetricalMatrix<T> matrix, SymmetricalMatrix<T> addMatrix)
        {
            return new SymmetricalMatrix<T>(AddLogic(matrix, addMatrix));
        }

        public static SquareMatrix<T> Add<T>(this SymmetricalMatrix<T> matrix, SquareMatrix<T> addMatrix)
        {
            return new SquareMatrix<T>(AddLogic(matrix, addMatrix));
        }

        public static DiagonalMatrix<T> Add<T>(this DiagonalMatrix<T> matrix, DiagonalMatrix<T> addMatrix)
        {
            return new DiagonalMatrix<T>(AddLogic(matrix, addMatrix));
        }

        public static SymmetricalMatrix<T> Add<T>(this DiagonalMatrix<T> matrix, SymmetricalMatrix<T> addMatrix)
        {
            return new SymmetricalMatrix<T>(AddLogic(matrix, addMatrix));
        }

        public static SquareMatrix<T> Add<T>(this DiagonalMatrix<T> matrix, SquareMatrix<T> addMatrix)
        {
            return new SquareMatrix<T>(AddLogic(matrix, addMatrix));
        }


        private static T[,] AddLogic<T>(SquareMatrix<T> matrix,SquareMatrix<T> addMatrix)
        {
            int newSize = Enumerable.Max<int>(new[] { matrix.Size, addMatrix.Size });
            var sumMatrix = new T[newSize, newSize];
            var firstMatrix = Resize<T>(matrix, newSize);
            var secondMatrix = Resize<T>(addMatrix, newSize);
            for (var i = 0; i < newSize; i++)
                for (var j = 0; j < newSize; j++)
                {
                    sumMatrix[i, j] = AddType<T>(firstMatrix[i, j], secondMatrix[i, j]);
                }
            return sumMatrix;

        }

        private static dynamic AddType<T>(dynamic x, dynamic y)
        {
            return (T)(x + y);
        }

        private static T[,] Resize<T>(SquareMatrix<T> matrix,int newSize)
        {
            var newMatrix = new T[newSize, newSize];
            for (var i = 0; i < matrix.Size; i++)
                for (var j = 0; j < matrix.Size; j++)
                {
                    newMatrix[i, j] = matrix[i,j];
                }
            return newMatrix;
        }


    }
}
